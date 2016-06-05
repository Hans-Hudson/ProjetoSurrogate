using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoSurrogateWeb.Startup))]
namespace ProjetoSurrogateWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
