using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AviaTor.Startup))]
namespace AviaTor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
