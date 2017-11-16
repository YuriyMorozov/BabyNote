using System;
using System.Collections.Generic;
using ChildrenCalendar.Domain.Entities;
using System.Linq;
using System.Web;

namespace ChildrenCalendar.Models
{
    public class SleepListViewModel
    {
        public IEnumerable<Sleep> Sleeps { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public Time time = new Time();
        public Sleep sleep = new Sleep();
    }
}