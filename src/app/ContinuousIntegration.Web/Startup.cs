using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContinuousIntegration.Web.Startup))]
namespace ContinuousIntegration.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
