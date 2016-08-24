using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WroxMvcCh4.Startup))]
namespace WroxMvcCh4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
