using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class DetaBaseCountext : DbContext{
        public DetaBaseCountext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotelcs> Hotels { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    CountryName = "Jordon",
                    ShortName = "JOR"
                },
                new Country
                {
                    Id = 2,
                    CountryName = "Kuwait",
                    ShortName = "KUW"
                },
                new Country
                {
                    Id = 3,
                    CountryName = "Bahrain",
                    ShortName = "BAH"
                }
            );
            modelBuilder.Entity<Hotelcs>().HasData(
                new Hotelcs
                {
                    Id = 1,
                    HotelName = "Kempinski",
                    Address = "Amman",
                    CountryId = 1,
                    Rating = 5.0
                },
                new Hotelcs
                {
                    Id = 2,
                    HotelName = "Jumeirah",
                    Address = "Kuwait City",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotelcs
                {
                    Id = 3,
                    HotelName = "Gulf Hotel",
                    Address = "Manama",
                    CountryId = 3,
                    Rating = 4.0
                }
            );
        }

    }
}
