using System;
using Microsoft.AspNet.Identity.EntityFramework;


namespace ChildrenCalendar.Domain.Entities
{
    public enum Gender
    {
        Male, Female
    }
    public class AppUser : IdentityUser
    {
        public Gender Gen { get; set; }
    }
}