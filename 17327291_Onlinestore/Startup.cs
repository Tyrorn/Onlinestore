using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_17327291_Onlinestore.Startup))]
namespace _17327291_Onlinestore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
