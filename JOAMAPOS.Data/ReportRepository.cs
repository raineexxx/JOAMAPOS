using System;
using System.Collections.Generic;
using System.Linq;
using JOAMAPOS.Domain;

namespace JOAMAPOS.Data
{
    public class ReportRepository
    {
        // dbo.usp_Report_Dashboard
        public DashboardDto GetDashboard()
        {
            using (var db = DbFactory.Create())
            {
                var r = db.usp_Report_Dashboard().FirstOrDefault();
                if (r == null) return new DashboardDto();

                return new DashboardDto
                {
                    TodaySales = Convert.ToDecimal(r.TodaySales),
                    TodayOrders = Convert.ToInt32(r.TodayOrders),
                    LowStockCount = Convert.ToInt32(r.LowStockCount),
                    ActiveProducts = Convert.ToInt32(r.ActiveProducts)
                };
            }
        }

        // dbo.usp_Report_LowStock
        public List<LowStockDto> GetLowStock()
        {
            using (var db = DbFactory.Create())
            {
                return db.usp_Report_LowStock()
                    .Select(r => new LowStockDto
                    {
                        ProductId = Convert.ToInt32(r.ProductId),
                        Sku = r.Sku,
                        Name = r.Name,
                        StockQty = Convert.ToInt32(r.StockQty),
                        ReorderLevel = Convert.ToInt32(r.ReorderLevel)
                    })
                    .ToList();
            }
        }
    }
}