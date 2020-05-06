using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SistemaAluno.StartupOwin))]

namespace SistemaAluno
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
