﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ChildrenCalendar.Domain.Entities
{
    public class Vaccination
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }
        public string Vaccine { get; set; }
        public int? Years { get; set; }
        public int? Months { get; set; } 
        public string Comment { get; set; }
        public string UserId { get; set; }
    }
}