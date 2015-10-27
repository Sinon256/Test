using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Retail_store_online.Startup))]
namespace Retail_store_online
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
