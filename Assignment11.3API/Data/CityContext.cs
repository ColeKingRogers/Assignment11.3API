using Microsoft.EntityFrameworkCore;
using Assignment11._3API.Model;

namespace Assignment11._3API.Data
{
    public class CityContext: DbContext
    {
        public CityContext(DbContextOptions<CityContext> options) : base(options)
        {
        }
        public DbSet<City> cities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                                    new City { Id = 1, Name = "New York", Country = "USA", Population = 8419600 },
                                    new City { Id = 2, Name = "Los Angeles", Country = "USA", Population = 3980400 },
                                    new City { Id = 3, Name = "Chicago", Country = "USA", Population = 2716000 }
                                                                             );
        }
    }
}
