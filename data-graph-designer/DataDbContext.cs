using Microsoft.EntityFrameworkCore;

namespace data_graph_designer
{
    public class DataDbContext: DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options)
        : base(options)
        {
        }
    }
}
