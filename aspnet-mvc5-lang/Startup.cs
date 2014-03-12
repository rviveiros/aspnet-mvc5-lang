using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnet_mvc5_lang.Startup))]
namespace aspnet_mvc5_lang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
