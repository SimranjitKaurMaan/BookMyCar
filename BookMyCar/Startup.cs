using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookMyCar.Startup))]
namespace BookMyCar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
