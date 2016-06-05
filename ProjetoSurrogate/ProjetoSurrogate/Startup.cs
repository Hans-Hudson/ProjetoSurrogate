using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoSurrogate.Startup))]
namespace ProjetoSurrogate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
