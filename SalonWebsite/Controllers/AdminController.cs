using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalonWebsite.Data;

namespace SalonWebsite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
    
        private SalonDbContext db = new SalonDbContext();

        public ActionResult Index()
        {
            ViewBag.TotalServices = db.Services.Count();
            ViewBag.TotalGallery = db.Galleries.Count();
            ViewBag.TotalAbout = db.Abouts.Count();
            ViewBag.TotalContact = db.Contacts.Count();

            var recentServices = db.Services
                                   .OrderByDescending(s => s.ServiceId)
                                   .Take(5)
                                   .ToList();

            return View(recentServices);
        }
    }
}