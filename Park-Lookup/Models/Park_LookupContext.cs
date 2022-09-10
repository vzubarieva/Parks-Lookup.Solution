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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
            .Entity<Park>()
            .HasData(
                 new Park 
                { 
                    ParkId = 1,
                     Name = "Bridle Trails State Park", 
                     Type = "State park",
                     Location = "Washington state"
                },
                new Park 
                { 
                    ParkId = 2,
                     Name = "Lake Sammamish State Park", 
                     Type = "State park",
                     Location = "Washington state"
                },
                new Park 
                { 
                    ParkId = 3,
                     Name = "Saint Edward State Park", 
                     Type = "State park",
                     Location = "Washington state"
                },
                new Park 
                { 
                    ParkId = 4,
                     Name = "Bear Creek Park", 
                     Type = "State park",
                     Location = "Washington state"
                },
                new Park 
                { 
                    ParkId = 5,
                     Name = "Olympic National Park", 
                     Type = "National park",
                     Location = "Washington state"
                },
                new Park 
                { 
                    ParkId = 6,
                     Name = "Mount Rainier National Park", 
                     Type = "National park",
                     Location = "Washington state"
                },
                new Park 
                { 
                    ParkId = 7,
                     Name = "North Cascades National Park", 
                     Type = "National park",
                     Location = "Washington state"
                },
                new Park 
                { 
                    ParkId = 8,
                     Name = "Crater Lake National Park", 
                     Type = "National park",
                     Location = "Oregon state"
                }     
             );
        }
    }
}