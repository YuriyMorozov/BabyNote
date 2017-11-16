using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChildrenCalendar.Infrastructure;

namespace ChildrenCalendar.Controllers
{

    public class HomeController : Controller
    {
        // GET: Home
        public RedirectToRouteResult Index()
        {
            return RedirectToAction("List", "Sleep");
        }

        public ActionResult DevelopmentInfo()
        {
            return View();
        }

        public ActionResult AboutInfo()
        {
            return View();
        }

        public ActionResult OneMonth()
        {
            return View();
        }

        [HttpGet]
        public EmptyResult ChangeCulture(string lang)
        {
           
            string returnUrl = Request.UrlReferrer.AbsolutePath;
            // Список культур
            List<string> cultures = new List<string>() { "uk", "en", "ru" };
            if (!cultures.Contains(lang))
            {
                lang = "en";
            }
            // Сохраняем выбранную культуру в куки
            HttpCookie cookie = Request.Cookies["lang"];
            if (cookie != null)
                cookie.Value = lang;   // если куки уже установлено, то обновляем значение
            else
            {

                cookie = new HttpCookie("lang");
                cookie.HttpOnly = false;
                cookie.Value = lang;
                cookie.Expires = DateTime.Now.AddYears(1);
            }
            Response.Cookies.Add(cookie);
            return null;
        }
    }
}