using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChildrenCalendar.Domain.Abstract;
using ChildrenCalendar.Domain.Entities;
using ChildrenCalendar.Domain.Concrete;
using ChildrenCalendar.Models;

namespace ChildrenCalendar.Controllers
{
    public class VaccinationController : Controller
    {
        private IRepository repository;
        public int PageSize = 10;
        EFDbContext DBcontext = new EFDbContext();

        public VaccinationController(IRepository vaccinationRepository)
        {
            repository = vaccinationRepository;
        }

        public ActionResult List(string vac = null, int page = 1)
        {
            ViewBag.Controller = "Vaccination";
            IEnumerable<Vaccination> vaccinations = repository.Vaccinations.ToList();

            VaccinationListViewModel model = new VaccinationListViewModel
            {

                Vaccinations = vaccinations.Where(x => (x.Vaccine == vac)),
                PagingInfo = new PagingInfo { CurrentPage = page, ItemsPerPage = PageSize, TotalItems = repository.Sleeps.Count() }
            };
            return View(model);
        }
    }
}