using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QueryRunnerWebApp.Startup))]
namespace QueryRunnerWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
