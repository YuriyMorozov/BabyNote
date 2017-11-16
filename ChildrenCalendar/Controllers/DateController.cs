using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChildrenCalendar.Models;

namespace ChildrenCalendar.Controllers
{
    public class DateController : Controller
    {
        public ActionResult Index(string date)
        {
            if (date != null)
            {
                string[] Date = date.Split('.');
                int day = Convert.ToInt32(Date[0]);
                int month = Convert.ToInt32(Date[1]);
                int year = Convert.ToInt32(Date[2]);
                Models.Date.date = new DateTime(year, month, day);

            }
            return new EmptyResult();
        }
    }
}