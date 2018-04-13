using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeveloperMovieProject.Startup))]
namespace DeveloperMovieProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
