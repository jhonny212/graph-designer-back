using data_graph_designer.Models;
using Microsoft.EntityFrameworkCore;

namespace data_graph_designer.Repository
{

    public class DashboardRowRepository : CrudBaseRepository<DashboardRow>
    {
        public DashboardRowRepository(GraphDesignerContext context) : base(context)
        {
        }
    }
}