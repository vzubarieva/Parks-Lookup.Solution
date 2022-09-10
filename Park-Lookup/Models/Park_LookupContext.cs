using Microsoft.EntityFrameworkCore;

namespace Park_Lookup.Models
{
    public class Park_LookupContext : DbContext
    {
        public Park_LookupContext(DbContextOptions<Park_LookupContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }
    }
}