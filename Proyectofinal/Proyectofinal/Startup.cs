using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proyectofinal.Startup))]
namespace Proyectofinal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
