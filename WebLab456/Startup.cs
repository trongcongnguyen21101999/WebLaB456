using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebLab456.Startup))]
namespace WebLab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
