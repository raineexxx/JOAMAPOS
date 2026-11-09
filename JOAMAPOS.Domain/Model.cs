namespace JOAMAPOS.Domain
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public string FullName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
    }

    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }

    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int StockQty { get; set; }
        public int ReorderLevel { get; set; }
        public bool IsActive { get; set; }
    }

    public class DashboardDto
    {
        public decimal TodaySales { get; set; }
        public int TodayOrders { get; set; }
        public int LowStockCount { get; set; }
        public int ActiveProducts { get; set; }
    }

    public class LowStockDto
    {
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public int StockQty { get; set; }
        public int ReorderLevel { get; set; }
    }
}