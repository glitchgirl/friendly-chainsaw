using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(joesGolfSite.Startup))]
namespace joesGolfSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
