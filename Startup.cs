using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookKeeper.Startup))]
namespace BookKeeper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
