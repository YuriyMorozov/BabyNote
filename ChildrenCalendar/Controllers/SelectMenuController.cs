using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChildrenCalendar.Controllers
{
    //not used now
    public class SelectMenuController : Controller
    {
        // GET: SelectMenu
        public RedirectToRouteResult GoTo(string goToContr)
        {
        
            return RedirectToAction ("List", goToContr);
        }
    }
}