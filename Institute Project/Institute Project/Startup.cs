using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(School_Project.Startup))]
namespace School_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
