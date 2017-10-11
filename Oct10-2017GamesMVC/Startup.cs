using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oct10_2017GamesMVC.Startup))]
namespace Oct10_2017GamesMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
