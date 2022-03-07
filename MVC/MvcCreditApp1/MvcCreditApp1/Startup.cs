using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MvcCreditApp1.StartupOwin))]

namespace MvcCreditApp1
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
