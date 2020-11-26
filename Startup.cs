using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibreriaMvc.Startup))]
namespace LibreriaMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
