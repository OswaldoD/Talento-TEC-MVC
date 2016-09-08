using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Talento_TEC_MVC.Startup))]
namespace Talento_TEC_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
