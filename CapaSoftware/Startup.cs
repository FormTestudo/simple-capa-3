using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapaSoftware.Startup))]
namespace CapaSoftware
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
