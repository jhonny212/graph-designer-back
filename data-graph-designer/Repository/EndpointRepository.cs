using Microsoft.EntityFrameworkCore;

namespace data_graph_designer.Repository
{

    public class EndpointRepository : CrudBaseRepository<Models.Endpoint>
    {
        public EndpointRepository(GraphDesignerContext context) : base(context)
        {
        }

        public Task<List<Models.Endpoint>> getEndpointsByType(int type)
        {
            return _context.Endpoints.Where(p=>p.EndpointTypeId == type).ToListAsync();
        }
    }
}