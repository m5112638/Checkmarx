using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Checkmarx.Startup))]
namespace Checkmarx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
