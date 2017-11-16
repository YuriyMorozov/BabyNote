using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ChildrenCalendar.Domain.Entities
{
    public class NatFeed
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? FeedHour { get; set; }
        public int? FeedMinute { get; set; }
        public string Breast { get; set; }
        public int? Minutes { get; set; }
        public string Puke { get; set; }
        public string Hiccup { get; set; }
    }
}