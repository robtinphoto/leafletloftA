using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(leafletloftA.Startup))]
namespace leafletloftA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
