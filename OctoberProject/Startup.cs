using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OctoberProject.Startup))]
namespace OctoberProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
