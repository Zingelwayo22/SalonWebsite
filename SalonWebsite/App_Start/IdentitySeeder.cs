using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SalonWebsite.Data;
using SalonWebsite.Models.Identity;
using System;

namespace SalonWebsite.App_Start
{
    public static class IdentitySeeder
    {
        public static void Seed()
        {
            using (var context = new SalonDbContext())
            {
                context.Database.CreateIfNotExists();

                var roleManager = new RoleManager<IdentityRole>(
                    new RoleStore<IdentityRole>(context));

                var userManager = new ApplicationUserManager(
                    new UserStore<ApplicationUser>(context));

                // Create Admin role if it doesn't exist
                if (!roleManager.RoleExists("Admin"))
                {
                    roleManager.Create(new IdentityRole("Admin"));
                }

                // Find the administrator
                var admin = userManager.FindByEmail("admin@salon.com");

                // Create administrator if it doesn't exist
                if (admin == null)
                {
                    admin = new ApplicationUser
                    {
                        UserName = "admin@salon.com",
                        Email = "admin@salon.com",
                        EmailConfirmed = true,
                        FirstName = "Salon",
                        LastName = "Administrator"
                    };

                    var result = userManager.Create(
                        admin,
                        "Admin@123");

                    if (!result.Succeeded)
                    {
                        throw new Exception(
                            string.Join(", ", result.Errors));
                    }
                }

                // Make sure administrator has Admin role
                if (!userManager.IsInRole(admin.Id, "Admin"))
                {
                    userManager.AddToRole(admin.Id, "Admin");
                }
            }
        }
    }
}