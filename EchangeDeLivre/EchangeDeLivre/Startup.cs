using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EchangeDeLivre.Startup))]
namespace EchangeDeLivre
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
