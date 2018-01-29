using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIC.Startup))]
namespace SIC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
