using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CURS7.Startup))]
namespace CURS7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
