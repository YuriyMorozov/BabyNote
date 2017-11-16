using System;
using System.Collections.Generic;
using ChildrenCalendar.Domain.Entities;
using System.Linq;
using System.Web;

namespace ChildrenCalendar.Models
{
    public class VaccinationListViewModel
    {
        public IEnumerable<Vaccination> Vaccinations { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public Age time = new Age();
        public Vaccination vac = new Vaccination();
    }
}