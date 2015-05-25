using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogSys.Web.Startup))]
namespace BlogSys.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
