using System.Collections.Generic;
using JOAMAPOS.Data;
using JOAMAPOS.Domain;

namespace JOAMAPOS.Services
{
    public class DashboardService
    {
        private readonly ReportRepository _reports = new ReportRepository();

        public DashboardDto GetMetrics()
        {
            return SqlGuard.Query(() => _reports.GetDashboard());
        }

        public List<LowStockDto> GetLowStock()
        {
            return SqlGuard.Query(() => _reports.GetLowStock());
        }
    }
}