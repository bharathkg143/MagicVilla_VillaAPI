using Microsoft.EntityFrameworkCore;
using Project_MagicVilla_API.Models;

namespace Project_MagicVilla_API.Context
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "We have a few other developers using the same solution code (myself included) that have not issues with add-migration.",
                    ImageUrl= "https://th.bing.com/th?id=OIP.1YM53mG10H_U25iPjop83QHaEo&w=316&h=197&c=8&rs=1&qlt=90&o=6&dpr=1.3&pid=3.1&rm=2",
                    Occupancy=10,
                    Rate=10000,
                    Sqrft=50 
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Forest Villa",
                    Details = "We have a few other developers using the same solution code (myself included) that have not issues with add-migration.",
                    ImageUrl = "https://th.bing.com/th?id=OIP.aj48y9KXH2xOZ46X9NvKJQHaEo&w=316&h=197&c=8&rs=1&qlt=90&o=6&dpr=1.3&pid=3.1&rm=2",
                    Occupancy = 20,
                    Rate = 20000,
                    Sqrft = 100
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Beach Villa",
                    Details = "We have a few other developers using the same solution code (myself included) that have not issues with add-migration.",
                    ImageUrl = "https://th.bing.com/th?id=OIP.Vt3kGu4X6WQlmH91GpJpzgHaFH&w=300&h=207&c=8&rs=1&qlt=90&o=6&dpr=1.3&pid=3.1&rm=2",
                    Occupancy = 5,
                    Rate = 30000,
                    Sqrft = 200
                }
            );
        }
    }
}
