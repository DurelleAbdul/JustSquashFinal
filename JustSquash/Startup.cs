using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JustSquash.Startup))]
namespace JustSquash
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
