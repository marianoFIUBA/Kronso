using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kronso.Startup))]
namespace Kronso
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
