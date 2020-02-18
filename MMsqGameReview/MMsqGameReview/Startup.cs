using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MMsqGameReview.Startup))]
namespace MMsqGameReview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
