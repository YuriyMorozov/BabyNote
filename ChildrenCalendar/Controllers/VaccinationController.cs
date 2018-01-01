
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ChildrenCalendar.Domain.Abstract;
using ChildrenCalendar.Domain.Entities;
using ChildrenCalendar.Domain.Infrastructure;
using ChildrenCalendar.Models;
using Microsoft.AspNet.Identity;

namespace ChildrenCalendar.Controllers
{
    public class VaccinationController : Controller
    {
        private IRepository repository;
        public int PageSize = 10;
        AppDbContext DBcontext = new AppDbContext();

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

                Vaccinations = vaccinations.Where(x => (x.UserId == User.Identity.GetUserId()) && (x.Vaccine == vac)),
                PagingInfo = new PagingInfo { CurrentPage = page, ItemsPerPage = PageSize, TotalItems = repository.Sleeps.Count() }
            };
            return View(model);
        }
    }
}