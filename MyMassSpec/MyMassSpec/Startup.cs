using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMassSpec.Startup))]
namespace MyMassSpec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
