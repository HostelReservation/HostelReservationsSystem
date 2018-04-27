using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HostelReservationsSystem.Startup))]
namespace HostelReservationsSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
