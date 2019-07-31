using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MitraisTest.Startup))]
namespace MitraisTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
