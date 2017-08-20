using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppWebMusic.Startup))]
namespace AppWebMusic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
