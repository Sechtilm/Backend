using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultibleChoiceAppFinal.Startup))]
namespace MultibleChoiceAppFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
