using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WheelEstate.Models.Enums;
using WheelEstate.Models;

namespace WheelEstate.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseAlways<ApplicationDbContext>());
        }

        // Wheel Estate Tables
        public DbSet<RoadTrip> RoadTrips { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Remap AspNetUser table to USers
            modelBuilder.Entity<ApplicationUser>().ToTable("Users", "dbo");

            modelBuilder.Entity<RoadTrip>()
                .HasMany<Sight>(rt => rt.Sights)
                .WithMany(s => s.RoadTrips)
                .Map(m =>
                {
                    m.MapLeftKey("RoadTripRefId");
                    m.MapRightKey("SightRefId");
                    m.ToTable("RoadTripSight");
                });
            modelBuilder.Entity<RoadTrip>()
                .HasMany<Campground>(rt => rt.Campgrounds)
                .WithMany(c => c.RoadTrips)
                .Map(m =>
                {
                    m.MapLeftKey("RoadTripRefId");
                    m.MapRightKey("CampgroundRefId");
                    m.ToTable("RoadTripCampground");
                });
            modelBuilder.Entity<RoadTrip>()
                .HasMany(rt => rt.FoodAndDrinks)
                .WithMany(s => s.RoadTrips)
                .Map(m =>
                {
                    m.MapLeftKey("RoadTripRefId");
                    m.MapRightKey("FoodAndDrinkRefId");
                    m.ToTable("RoadTripFoodAndDrink");
                });

            modelBuilder.Entity<Campground>().HasMany(c => c.CampgroundReviews);

            modelBuilder.Entity<FoodAndDrink>().HasMany(f => f.FoodAndDrinkReviews);

            modelBuilder.Entity<Sight>().HasMany(s => s.SiteReviews);
        }
    }
}