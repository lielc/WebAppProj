using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppProj.Startup))]
namespace WebAppProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
