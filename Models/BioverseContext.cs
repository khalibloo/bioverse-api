using Microsoft.EntityFrameworkCore;

namespace Bioverse.Models
{
    public class BioverseContext : DbContext
    {
        public BioverseContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Family> Family { get; set; }
        public DbSet<Species> Species { get; set; }
    }
}
