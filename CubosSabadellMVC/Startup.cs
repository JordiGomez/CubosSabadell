using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CubosSabadellMVCMVC.Startup))]
namespace CubosSabadellMVCMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
