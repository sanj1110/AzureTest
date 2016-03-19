using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Azure.Startup))]
namespace Azure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
