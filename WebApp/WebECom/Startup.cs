using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebECom.Startup))]
namespace WebECom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
