using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WheelEstate.Startup))]
namespace WheelEstate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
