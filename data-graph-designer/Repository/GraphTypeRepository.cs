using data_graph_designer.Models;
using Microsoft.EntityFrameworkCore;

namespace data_graph_designer.Repository
{

    public class GraphTypeRepository : CrudBaseRepository<TypeGraph>
    {
        public GraphTypeRepository(GraphDesignerContext context) : base(context)
        {
        }
    }
}