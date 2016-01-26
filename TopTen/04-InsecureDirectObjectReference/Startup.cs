using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_04_InsecureDirectObjectReference.Startup))]
namespace _04_InsecureDirectObjectReference
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
