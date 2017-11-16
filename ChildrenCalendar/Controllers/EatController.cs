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
    public class EatController : Controller
    {
        private IRepository repository;
        public int PageSize = 10;
        EFDbContext DBcontext = new EFDbContext();

        public EatController(IRepository eatRepository)
        {
            repository = eatRepository;
        }

        public ViewResult List(int page = 1)
        {
            ViewBag.Controller = "Eat";
            IEnumerable<NatFeed> feeds = repository.NatFeeds.ToList();

            EatListViewModel model = new EatListViewModel
            {
                /*Skip((page - 1) * PageSize).Take(PageSize).*/
                NatFeeds = feeds.Where(x => (x.Date.Value.Year == Date.date.Year) && (x.Date.Value.Month == Date.date.Month) && (x.Date.Value.Day == Date.date.Day)),
                PagingInfo = new PagingInfo { CurrentPage = page, ItemsPerPage = PageSize, TotalItems = repository.Sleeps.Count() }
            };
            return View(model);
        }

        public RedirectToRouteResult AddToDB(NatFeed natFeed, string returnUrl)
        {
            natFeed.Date = Date.date;
            DBcontext.NatFeeds.Add(natFeed);
            DBcontext.SaveChanges();
            DBcontext.Dispose();

            return RedirectToAction("List", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromDB(NatFeed feed)
        {

            IEnumerable<NatFeed> feeds = DBcontext.NatFeeds.Where(x => x.Id == feed.Id);
            NatFeed fd = feeds.LastOrDefault();
            if (fd != null)
            {
                DBcontext.NatFeeds.Remove(fd);
                DBcontext.SaveChanges();
                DBcontext.Dispose();
            }
            return RedirectToAction("List");
        }

        public ActionResult EditDB(NatFeed natFeed)
        {
            NatFeed nf = DBcontext.NatFeeds.FirstOrDefault(x => x.Id == natFeed.Id);
            return PartialView(nf);
        }

        public RedirectToRouteResult SaveDB(NatFeed natFeed, string returnUrl)
        {
            DBcontext.Entry(natFeed).State = System.Data.Entity.EntityState.Modified;
            DBcontext.SaveChanges();
            return RedirectToAction("List", new { returnUrl });
        }

    }
}