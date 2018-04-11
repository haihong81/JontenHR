using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JontenHR.Startup))]
namespace JontenHR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
