using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using ChildrenCalendar.Domain.Entities;
using Microsoft.AspNet.Identity;

namespace ChildrenCalendar.Domain.Infrastructure
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Sleep> Sleep { get; set; }
        public DbSet<NatFeed> NatFeeds { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }

        public AppDbContext() : base("EFDbContext") { }
        static AppDbContext()
        {
            Database.SetInitializer<AppDbContext>(new IdentityDbInit());
        }
        public static AppDbContext Create()
        {
            return new AppDbContext();
        }
    }

    public class IdentityDbInit : NullDatabaseInitializer<AppDbContext>
    {
    }
}
