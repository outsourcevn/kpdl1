using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kpdl1.Startup))]
namespace kpdl1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
