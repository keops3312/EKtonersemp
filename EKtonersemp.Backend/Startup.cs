using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EKtonersemp.Backend.Startup))]
namespace EKtonersemp.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
