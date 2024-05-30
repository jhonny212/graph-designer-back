using data_graph_designer.Interfaces;
using data_graph_designer.Models;
using Microsoft.EntityFrameworkCore;

namespace data_graph_designer.Repository
{
    public class CrudBaseRepository<U> : ICrudRepository<U> where U : class
    {
        public readonly GraphDesignerContext _context;
        public CrudBaseRepository(GraphDesignerContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteById(int id)
        {
            var entity = await GetById(id);
            if (entity == null)
            {
                return false;
            }
            _context.Set<U>().Remove(entity);
            return true;
        }

        public async Task<IEnumerable<U>> GetAll()
        {
            return await _context.Set<U>().ToArrayAsync();
        }

        public IQueryable<U> getPaginatedQuery(int page, int pageSize)
        {
            var query = _context.Set<U>().AsQueryable();
            query = query.OrderBy(x => EF.Property<int>(x, "Id"));
            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            return query;
        }


        public async Task<IEnumerable<U>> GetAllPaginated(int page, int pageSize)
        {
            return await getPaginatedQuery(page, pageSize).ToArrayAsync();
        }

        public async Task<U> GetById(int id)
        {
            return await _context.Set<U>().FindAsync(id);
        }

        public async Task<U> Save(U entity)
        {
            //_context.Dashboards
            await _context.Set<U>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<U> Update(U entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
