using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VEB.Startup))]
namespace VEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
