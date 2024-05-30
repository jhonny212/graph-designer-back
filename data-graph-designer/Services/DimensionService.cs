using System.Collections;
using data_graph_designer.Interfaces;
using data_graph_designer.Models;
using Microsoft.EntityFrameworkCore;

namespace data_graph_designer.Service
{
    public class DimensionService
    {
        private readonly GraphDesignerContext _context;
        public DimensionService(GraphDesignerContext context){
            this._context = context;
        }

        public async Task<IEnumerable<DashboardColumn>> GetDashboardColumns(){
            return await _context.DashboardColumns.ToArrayAsync();
        }

        public async Task<IEnumerable<Height>> GetRows(){
            return await _context.Heights.ToArrayAsync();
        } 

    }
}