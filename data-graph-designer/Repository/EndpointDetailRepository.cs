using data_graph_designer.Models;
using Microsoft.EntityFrameworkCore;

namespace data_graph_designer.Repository
{
    public class EndpointDetailRepository : CrudBaseRepository<EndpointDetail>
    {
        public EndpointDetailRepository(GraphDesignerContext context) : base(context)
        {
        }

        public Task<List<EndpointDetail>> GetAllEndpointDetailsByEndpoint(int id)
        {
            return _context.EndpointDetails.Where(p=>p.EndpointId == id).Include(p=>p.TypeData).ToListAsync();
        }
    }
}