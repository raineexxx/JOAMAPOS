using System.Collections.Generic;
using JOAMAPOS.Data;
using JOAMAPOS.Domain;

namespace JOAMAPOS.Services
{
    public class ProductService
    {
        private readonly ProductRepository _repo = new ProductRepository();

        public List<CategoryDto> GetCategories()
        {
            return SqlGuard.Query(() => _repo.GetCategories());
        }

        public List<ProductDto> Search(string term, bool includeInactive)
        {
            return SqlGuard.Query(() => _repo.Search(term, includeInactive));
        }

        public void Add(ProductDto p)
        {
            RequireManager();
            Validate(p);
            int uid = CurrentUserId();
            SqlGuard.Execute(() => _repo.Insert(p, uid));
        }

        public void Update(ProductDto p)
        {
            RequireManager();
            if (p == null || p.ProductId <= 0)
                throw new BusinessException("Select a product first.");
            Validate(p);
            SqlGuard.Execute(() => _repo.Update(p));
        }

        public void Deactivate(int productId)
        {
            RequireManager();
            if (productId <= 0)
                throw new BusinessException("Select a product first.");
            SqlGuard.Execute(() => _repo.Deactivate(productId));
        }

        public void AdjustStock(int productId, int changeQty, string reason)
        {
            RequireManager();
            if (productId <= 0)
                throw new BusinessException("Select a product first.");
            if (changeQty == 0)
                throw new BusinessException("Enter a quantity change (use a negative number to remove stock).");
            if (string.IsNullOrWhiteSpace(reason))
                throw new BusinessException("Reason is required.");
            if (reason.Trim().Length > 200)
                throw new BusinessException("Reason is too long (max 200 characters).");

            int uid = CurrentUserId();
            string r = reason.Trim();
            SqlGuard.Execute(() => _repo.AdjustStock(productId, changeQty, r, uid));
        }

        // ---------- rules ----------
        private static void RequireManager()
        {
            if (!Session.IsInRole(Roles.Admin, Roles.Manager))
                throw new BusinessException("You do not have permission to manage inventory.");
        }

        private static int CurrentUserId()
        {
            if (!Session.IsLoggedIn)
                throw new BusinessException("You are not logged in.");
            return Session.CurrentUser.UserId;
        }

        private static void Validate(ProductDto p)
        {
            if (p == null) throw new BusinessException("No product data.");
            if (string.IsNullOrWhiteSpace(p.Sku)) throw new BusinessException("SKU is required.");
            if (string.IsNullOrWhiteSpace(p.Name)) throw new BusinessException("Name is required.");
            if (p.CategoryId <= 0) throw new BusinessException("Select a category.");
            if (p.Price < 0) throw new BusinessException("Price cannot be negative.");
            if (p.Cost < 0) throw new BusinessException("Cost cannot be negative.");
            if (p.StockQty < 0) throw new BusinessException("Stock cannot be negative.");
            if (p.ReorderLevel < 0) throw new BusinessException("Reorder level cannot be negative.");

            p.Sku = p.Sku.Trim();
            p.Name = p.Name.Trim();
            p.Barcode = string.IsNullOrWhiteSpace(p.Barcode) ? null : p.Barcode.Trim();
        }
    }
}