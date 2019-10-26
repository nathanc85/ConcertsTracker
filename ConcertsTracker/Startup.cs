using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConcertsTracker.Startup))]
namespace ConcertsTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
