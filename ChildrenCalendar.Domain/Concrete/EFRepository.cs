using ChildrenCalendar.Domain.Abstract;
using ChildrenCalendar.Domain.Entities;
using System.Collections.Generic;

namespace ChildrenCalendar.Domain.Concrete
{
    public class EFRepository : IRepository
    {
        private EFDbContext context = new EFDbContext();

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