using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidyaCat2.MVC.Startup))]
namespace VidyaCat2.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
