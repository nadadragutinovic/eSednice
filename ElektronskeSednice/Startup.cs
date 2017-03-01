using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElektronskeSednice.Startup))]
namespace ElektronskeSednice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
