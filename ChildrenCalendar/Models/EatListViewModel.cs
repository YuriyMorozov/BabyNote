using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChildrenCalendar.Domain.Entities;

namespace ChildrenCalendar.Models
{
    public class EatListViewModel
    {
        public IEnumerable<NatFeed> NatFeeds { get; set; }
        public IEnumerable<Meal> Meals { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public Time time = new Time();
        public NatFeed natFeed = new NatFeed();
        public Meal meal = new Meal();
    }
}