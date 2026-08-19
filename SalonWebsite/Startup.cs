using Microsoft.Owin;
using Owin;
using SalonWebsite.App_Start;

[assembly: OwinStartup(typeof(SalonWebsite.Startup))]

namespace SalonWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            IdentitySeeder.Seed();
        }
    }
}