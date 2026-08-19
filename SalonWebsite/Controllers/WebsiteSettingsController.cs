using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SalonWebsite.Data;
using SalonWebsite.Models;

namespace SalonWebsite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class WebsiteSettingsController : Controller
    {
        private SalonDbContext db = new SalonDbContext();

        // GET: WebsiteSettings
        public ActionResult Index()
        {
            return View(db.WebsiteSettings.ToList());
        }

        // GET: WebsiteSettings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WebsiteSettings websiteSettings = db.WebsiteSettings.Find(id);
            if (websiteSettings == null)
            {
                return HttpNotFound();
            }
            return View(websiteSettings);
        }

        // GET: WebsiteSettings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WebsiteSettings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WebsiteSettingsId,SalonName,Tagline,HeroHeading,HeroDescription,Logo,HeroImage")] WebsiteSettings websiteSettings)
        {
            if (ModelState.IsValid)
            {
                db.WebsiteSettings.Add(websiteSettings);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(websiteSettings);
        }

        // GET: WebsiteSettings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WebsiteSettings websiteSettings = db.WebsiteSettings.Find(id);
            if (websiteSettings == null)
            {
                return HttpNotFound();
            }
            return View(websiteSettings);
        }

        // POST: WebsiteSettings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WebsiteSettingsId,SalonName,Tagline,HeroHeading,HeroDescription,Logo,HeroImage")] WebsiteSettings websiteSettings)
        {
            if (ModelState.IsValid)
            {
                db.Entry(websiteSettings).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(websiteSettings);
        }

        // GET: WebsiteSettings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WebsiteSettings websiteSettings = db.WebsiteSettings.Find(id);
            if (websiteSettings == null)
            {
                return HttpNotFound();
            }
            return View(websiteSettings);
        }

        // POST: WebsiteSettings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WebsiteSettings websiteSettings = db.WebsiteSettings.Find(id);
            db.WebsiteSettings.Remove(websiteSettings);
            db.SaveChanges();
            return RedirectToAction("Index");
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
