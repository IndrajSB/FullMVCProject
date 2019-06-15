using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullMVCProject_FilmStation.Startup))]
namespace FullMVCProject_FilmStation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
