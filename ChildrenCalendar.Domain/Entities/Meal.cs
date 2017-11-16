using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ChildrenCalendar.Domain.Entities
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? Hour { get; set; }
        public int? Minute { get; set; }
        public string TypeProduct { get; set; }
        public string Product { get; set; }
        public int? Gramms { get; set; }
        public string Comment { get; set; }
    }
}