using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MMSQ.Startup))]
namespace MMSQ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
