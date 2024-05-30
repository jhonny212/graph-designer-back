using data_graph_designer.Interfaces;
using data_graph_designer.Models;
using data_graph_designer.Repository;
using data_graph_designer.Services;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace data_graph_designer.Service{

    public class DashboardRowService : ServiceBase<DashboardRow>
    {
        public DashboardRowService(DashboardRowRepository repository) : base(repository)
        {
        }

        public async Task<IEnumerable<DashboardRow>> GetDashboardRowByDashboard(int page, int pageSize, int dashboardId)
        {
            var query = _repository.getPaginatedQuery(page, pageSize).Include(p => p.Columns).Where(p=>p.DashboardId==dashboardId);
            var data = await query.ToArrayAsync();
            return data;
        }
    }
}