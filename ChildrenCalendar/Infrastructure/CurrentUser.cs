using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChildrenCalendar.Domain.Entities;
using ChildrenCalendar.Domain.Infrastructure;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace ChildrenCalendar.Infrastructure
{
    //public static class CurrentUser
    //{
    //    //public static AppUser UserId(HttpContext context)
    //    //{
    //    //    AppUser user = UserManager.FindById(context.User.Identity.GetUserId());
    //    //}

    //    public static AppUser CurrentUserId
    //    {
    //        get
    //        {
    //            return UserManager.FindById(HttpContext.User.Identity.GetUserId());
    //        }
    //    }

    //    private static AppUserManager UserManager
    //    {
    //        get
    //        {
    //            return HttpContext.GetOwinContext().GetUserManager<AppUserManager>();
    //        }
    //    }
    //    }
}
