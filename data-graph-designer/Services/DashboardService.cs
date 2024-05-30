using data_graph_designer.Interfaces;
using data_graph_designer.Models;
using data_graph_designer.Repository;
using data_graph_designer.Services;

namespace data_graph_designer.Service{
    public class DashboardService : ServiceBase<Dashboard>
    {
        public DashboardService(DashboardRepository repository) : base(repository)
        {
        }
    }
}