using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ChildrenCalendar.Domain.Entities
{
    public class Sleep
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }
        public int? AwakeHour { get; set; }
        public int? AwakeMinute { get; set; }
        public int? AsleepHour { get; set; }
        public int? AsleepMinute { get; set; }
        public string UserId { get; set; }
        public string Comment { get; set; }
    }
}