using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class DetaBaseCountext : DbContext{
        public DetaBaseCountext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotelcs> Hotels { get; set; }
    
    }
}
