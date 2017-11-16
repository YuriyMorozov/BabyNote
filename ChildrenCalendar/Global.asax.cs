using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ChildrenCalendar.Domain.Concrete;
using System.Data.Entity;
using ChildrenCalendar.Infrastructure;

namespace ChildrenCalendar
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer<EFDbContext>(null);
           
        }

        protected void Application_BeginRequest()
        {
            Infrastructure.CultureChange.Change();
        }
    }
}
