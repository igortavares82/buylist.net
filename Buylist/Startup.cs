using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Buylist.Startup))]
namespace Buylist
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
