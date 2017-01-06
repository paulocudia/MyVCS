using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Drive.Startup))]
namespace Drive
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
