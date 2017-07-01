using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StockMgt.Startup))]
namespace StockMgt
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
