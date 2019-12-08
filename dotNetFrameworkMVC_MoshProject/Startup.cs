using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dotNetFrameworkMVC_MoshProject.Startup))]
namespace dotNetFrameworkMVC_MoshProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
