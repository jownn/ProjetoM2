using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoM2.Startup))]
namespace ProjetoM2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
