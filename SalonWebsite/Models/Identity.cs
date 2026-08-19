using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SalonWebsite.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        // You can add custom properties later

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}