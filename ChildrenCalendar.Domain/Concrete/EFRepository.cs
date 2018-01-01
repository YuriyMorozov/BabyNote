using ChildrenCalendar.Domain.Abstract;
using ChildrenCalendar.Domain.Entities;
using ChildrenCalendar.Domain.Infrastructure;
using System.Collections.Generic;

namespace ChildrenCalendar.Domain.Concrete
{
    public class EFRepository : IRepository
    {
        private AppDbContext context = new AppDbContext();

        public IEnumerable<Sleep> Sleeps
        {
            get { return context.Sleep; }
        }

        public IEnumerable<NatFeed> NatFeeds
        {
            get { return context.NatFeeds; }
        }

        public IEnumerable<Meal> Meals
        {
            get { return context.Meals; }
        }

        public IEnumerable<Vaccination> Vaccinations
        {
            get { return context.Vaccinations; }
        }
    }
}