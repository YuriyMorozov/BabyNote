using ChildrenCalendar.Domain.Entities;
using System.Data.Entity;

namespace ChildrenCalendar.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Sleep> Sleep { get; set; }
        public DbSet<NatFeed> NatFeeds { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
    }
}