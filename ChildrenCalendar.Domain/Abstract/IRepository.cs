using System.Collections.Generic;
using ChildrenCalendar.Domain.Entities;

namespace ChildrenCalendar.Domain.Abstract
{
    public interface IRepository
    {
        IEnumerable<Sleep> Sleeps { get; }
        IEnumerable<NatFeed> NatFeeds { get; }
        IEnumerable<Meal> Meals { get; }
        IEnumerable<Vaccination> Vaccinations { get; }
    }
}