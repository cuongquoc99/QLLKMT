using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuanLyLKMT.Startup))]
namespace QuanLyLKMT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
