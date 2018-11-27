using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo.MVC_Iden.Startup))]
namespace Demo.MVC_Iden
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
