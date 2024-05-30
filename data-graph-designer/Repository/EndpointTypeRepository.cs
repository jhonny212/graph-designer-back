using data_graph_designer.Models;
using Microsoft.EntityFrameworkCore;

namespace data_graph_designer.Repository
{

    public class EndpointTypeRepository : CrudBaseRepository<EndpointType>
    {
        public EndpointTypeRepository(GraphDesignerContext context) : base(context)
        {
        }
    }
}