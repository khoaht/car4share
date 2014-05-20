using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oas.Car4Share.Startup))]
namespace Oas.Car4Share
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
