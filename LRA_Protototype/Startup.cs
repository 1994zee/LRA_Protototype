using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LRA_Protototype.Startup))]
namespace LRA_Protototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
