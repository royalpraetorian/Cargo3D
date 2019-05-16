using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cargo3DSite.Startup))]
namespace Cargo3DSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
