using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebRazor1.Startup))]
namespace WebRazor1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
