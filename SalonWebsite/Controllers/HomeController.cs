using SalonWebsite.Data;
using SalonWebsite.ViewModels;
using System.Web.Mvc;
using System.Linq;

namespace SalonWebsite.Controllers
{
    public class HomeController : Controller
    {
        private SalonDbContext db = new SalonDbContext();

        // GET: Home
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                WebsiteSettings = db.WebsiteSettings.FirstOrDefault(),
                About = db.Abouts.FirstOrDefault(),
                Services = db.Services.ToList(),
                Galleries = db.Galleries
              .Where(g => g.IsActive)
              .OrderBy(g => g.DisplayOrder)
              .ToList(),
                Contact = db.Contacts.FirstOrDefault()
            };

            return View(model);
        }

        // GET: About
        public ActionResult About()
        {
            return View();
        }

        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}