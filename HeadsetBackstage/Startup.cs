using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HeadsetBackstage.Startup))]
namespace HeadsetBackstage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
