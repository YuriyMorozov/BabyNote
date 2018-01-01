
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
    public class SleepController : Controller
    {

        private IRepository repository;
        public int PageSize = 10;
        AppDbContext DBcontext = new AppDbContext();
    
        public SleepController(IRepository sleepRepository)
        {
            repository = sleepRepository;
        }

        public ViewResult List(int page = 1)
        {
            ViewBag.Controller = "Sleep";
            IEnumerable<Sleep> sleeps = repository.Sleeps.ToList();

            SleepListViewModel model = new SleepListViewModel
            {
                /*Skip((page - 1) * PageSize).Take(PageSize).*/
                Sleeps = sleeps.Where(x => (x.UserId == User.Identity.GetUserId()) && (x.Date.Value.Year == Date.date.Year) && (x.Date.Value.Month == Date.date.Month) && (x.Date.Value.Day == Date.date.Day)),
                PagingInfo = new PagingInfo { CurrentPage = page, ItemsPerPage = PageSize, TotalItems = repository.Sleeps.Count() }
            };
            return View(model);
        }

        public RedirectToRouteResult AddToDB(Sleep sleep, string returnUrl)
        {
            sleep.UserId = User.Identity.GetUserId();
            sleep.Date = Date.date;
            DBcontext.Sleep.Add(sleep);
            DBcontext.SaveChanges();
            DBcontext.Dispose();

            return RedirectToAction("List", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromDB(Sleep sleep)
        {

            IEnumerable<Sleep> sleeps = DBcontext.Sleep.Where(x => x.Id == sleep.Id);
            Sleep sl = sleeps.LastOrDefault();
            if (sl != null)
            {
                DBcontext.Sleep.Remove(sl);
                DBcontext.SaveChanges();
                DBcontext.Dispose();
            }
            return RedirectToAction("List");
        }

        public ActionResult EditDB(Sleep sleep)
        {
            Sleep sl = DBcontext.Sleep.FirstOrDefault(x => x.Id == sleep.Id);
            return PartialView(sl);
        }

        public RedirectToRouteResult SaveDB(Sleep sleep)
        {
            sleep.UserId = User.Identity.GetUserId();
            DBcontext.Entry(sleep).State = System.Data.Entity.EntityState.Modified;
            DBcontext.SaveChanges();
            return RedirectToAction("List");
        }

    }
}