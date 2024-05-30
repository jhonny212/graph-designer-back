using data_graph_designer.Models;
using Microsoft.EntityFrameworkCore;

namespace data_graph_designer.Repository
{
    public class DashboardRepository : CrudBaseRepository<Dashboard>
    {
        public DashboardRepository(GraphDesignerContext context) : base(context)
        {
        }

    }
}
