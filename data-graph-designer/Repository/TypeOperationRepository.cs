using data_graph_designer.Models;
using Microsoft.EntityFrameworkCore;

namespace data_graph_designer.Repository
{

    public class TypeOperationRepository : CrudBaseRepository<TypeOperation>
    {
        public TypeOperationRepository(GraphDesignerContext context) : base(context)
        {
        }
    }
}