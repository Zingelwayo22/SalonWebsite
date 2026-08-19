using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SalonWebsite.Models;

namespace SalonWebsite.ViewModels
{
    public class HomeViewModel
    {
        public WebsiteSettings WebsiteSettings { get; set; }

        public About About { get; set; }

        public List<Service> Services { get; set; }

        public List<Gallery> Galleries { get; set; }

        public Contact Contact { get; set; }
    }
}