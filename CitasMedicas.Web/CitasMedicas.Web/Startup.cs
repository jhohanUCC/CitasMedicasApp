using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CitasMedicas.Web.Startup))]
namespace CitasMedicas.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
