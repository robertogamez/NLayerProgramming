using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExampleIdentityWebForms.Startup))]
namespace ExampleIdentityWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
