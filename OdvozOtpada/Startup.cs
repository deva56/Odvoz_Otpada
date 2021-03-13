using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OdvozOtpada.Startup))]
namespace OdvozOtpada
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
