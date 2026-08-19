using Microsoft.AspNet.Identity.EntityFramework;
using SalonWebsite.Models;
using SalonWebsite.Models.Identity;
using System.Data.Entity;

namespace SalonWebsite.Data
{
    public class SalonDbContext : IdentityDbContext<ApplicationUser>
    {
        public SalonDbContext()
            : base("SalonDbContext")
        {
        }

        public static SalonDbContext Create()
        {
            return new SalonDbContext();
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<WebsiteSettings> WebsiteSettings { get; set; }
    }
}