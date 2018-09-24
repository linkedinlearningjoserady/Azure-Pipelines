using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmazingApp.Startup))]
namespace AmazingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
