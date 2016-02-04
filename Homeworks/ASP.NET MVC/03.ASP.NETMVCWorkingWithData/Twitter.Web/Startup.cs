using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Twitter.Web.Startup))]
namespace Twitter.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
