using System.Collections.Generic;
using System.Linq;
using JOAMAPOS.Domain;

namespace JOAMAPOS.Data
{
    public class ProductRepository
    {
        public List<CategoryDto> GetCategories()
        {
            using (var db = DbFactory.Create())
            {
                return db.Categories
                    .OrderBy(c => c.Name)
                    .Select(c => new CategoryDto { CategoryId = c.CategoryId, Name = c.Name })
                    .ToList();
            }
        }

        public List<ProductDto> Search(string term, bool includeInactive)
        {
            term = (term ?? "").Trim();

            using (var db = DbFactory.Create())
            {
                var q = from p in db.Products
                        join c in db.Categories on p.CategoryId equals c.CategoryId
                        where (includeInactive || p.IsActive)
                              && (term == ""
                                  || p.Name.Contains(term)
                                  || p.Sku.Contains(term)
                                  || p.Barcode.Contains(term))
                        orderby p.Name
                        select new ProductDto
                        {
                            ProductId = p.ProductId,
                            Sku = p.Sku,
                            Barcode = p.Barcode,
                            Name = p.Name,
                            CategoryId = p.CategoryId,
                            CategoryName = c.Name,
                            Price = p.Price,
                            Cost = p.Cost,
                            StockQty = p.StockQty,
                            ReorderLevel = p.ReorderLevel,
                            IsActive = p.IsActive
                        };

                return q.ToList();
            }
        }

        // CREATE: dbo.usp_Product_Insert
        public void Insert(ProductDto p, int userId)
        {
            using (var db = DbFactory.Create())
            {
                db.usp_Product_Insert(p.Sku, p.Barcode, p.Name, p.CategoryId,
                                      p.Price, p.Cost, p.StockQty, p.ReorderLevel,
                                      null, userId);
            }
        }

        // UPDATE: dbo.usp_Product_Update
        public void Update(ProductDto p)
        {
            using (var db = DbFactory.Create())
            {
                db.usp_Product_Update(p.ProductId, p.Sku, p.Barcode, p.Name, p.CategoryId,
                                      p.Price, p.Cost, p.ReorderLevel, p.IsActive,
                                      null, false);
            }
        }

        // DELETE (soft): dbo.usp_Product_Delete
        public void Deactivate(int productId)
        {
            using (var db = DbFactory.Create())
            {
                db.usp_Product_Delete(productId);
            }
        }

        // STOCK: dbo.usp_Inventory_Adjust
        public void AdjustStock(int productId, int changeQty, string reason, int userId)
        {
            using (var db = DbFactory.Create())
            {
                db.usp_Inventory_Adjust(productId, changeQty, reason, userId);
            }
        }
    }
}