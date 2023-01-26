using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSite_pushing_Git_Manually.Startup))]
namespace WebSite_pushing_Git_Manually
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
