using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartialViewTest.Startup))]
namespace PartialViewTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
