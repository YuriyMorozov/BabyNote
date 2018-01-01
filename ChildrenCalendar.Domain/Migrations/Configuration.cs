namespace ChildrenCalendar.Domain.Migrations
{
    using System.Data.Entity.Migrations;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using ChildrenCalendar.Domain.Infrastructure;
    using ChildrenCalendar.Domain.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<ChildrenCalendar.Domain.Infrastructure.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ChildrenCalendar.Infrastructure.AppDbContext";
        }

        protected override void Seed(ChildrenCalendar.Domain.Infrastructure.AppDbContext context)
        {
            AppUserManager userMgr = new AppUserManager(new UserStore<AppUser>(context));
            AppRoleManager roleMgr = new AppRoleManager(new RoleStore<AppRole>(context));
            string roleName = "Administrators";
            string userName = "Admin";
            string password = "1231985OzzY0201456";
            string email = "ozzyman2015@gmail.com";

            if (!roleMgr.RoleExists(roleName))
            {
                roleMgr.Create(new AppRole(roleName));
            }

            AppUser user = userMgr.FindByName(userName);
            if (user == null)
            {
                userMgr.Create(new AppUser { UserName = userName, Email = email }, password);
                user = userMgr.FindByName(userName);
            }
            if (!userMgr.IsInRole(user.Id, roleName))
            {
                userMgr.AddToRole(user.Id, roleName);
            }
            //foreach (AppUser dbUser in userMgr.Users)
            //{
            //    dbUser.Gen = Gender.Male;
            //}
            context.SaveChanges();
        }
    }
}
