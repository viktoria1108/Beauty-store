using Microsoft.EntityFrameworkCore;

namespace Beauty_store.Models
{
    public class ProductDbContext: DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<ProductItems> ProductItems { get; set; }
    }
}
