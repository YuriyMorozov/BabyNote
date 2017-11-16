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
    public class MealController : Controller
    {
        private IRepository repository;
        public int PageSize = 10;
        EFDbContext DBcontext = new EFDbContext();

        public MealController(IRepository mealRepository)
        {
            repository = mealRepository;
        }

        public ViewResult List(int page = 1)
        {
            ViewBag.Controller = "Meal";
            IEnumerable<Meal> meals = repository.Meals.ToList();

            EatListViewModel model = new EatListViewModel
            {
                /*Skip((page - 1) * PageSize).Take(PageSize).*/
                Meals = meals.Where(x => (x.Date.Value.Year == Date.date.Year) && (x.Date.Value.Month == Date.date.Month) && (x.Date.Value.Day == Date.date.Day)),
                PagingInfo = new PagingInfo { CurrentPage = page, ItemsPerPage = PageSize, TotalItems = repository.Sleeps.Count() }
            };
            return View(model);
        }

        public RedirectToRouteResult AddToDB(Meal meal, string returnUrl)
        {
            meal.Date = Date.date;
            DBcontext.Meals.Add(meal);
            DBcontext.SaveChanges();
            DBcontext.Dispose();

            return RedirectToAction("List", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromDB(Meal meal)
        {
            IEnumerable<Meal> meals = DBcontext.Meals.Where(x => x.Id == meal.Id);
            Meal ml = meals.LastOrDefault();
            if (ml != null)
            {
                DBcontext.Meals.Remove(ml);
                DBcontext.SaveChanges();
                DBcontext.Dispose();
            }
            return RedirectToAction("List");
        }

        public ActionResult EditDB(Meal meal)
        {
            Meal nf = DBcontext.Meals.FirstOrDefault(x => x.Id == meal.Id);
            return PartialView(nf);
        }

        public RedirectToRouteResult SaveDB(Meal meal, string returnUrl)
        {
            DBcontext.Entry(meal).State = System.Data.Entity.EntityState.Modified;
            DBcontext.SaveChanges();
            return RedirectToAction("List", new { returnUrl });
        }

    }
}