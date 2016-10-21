using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Socandra.Startup))]
namespace Socandra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
