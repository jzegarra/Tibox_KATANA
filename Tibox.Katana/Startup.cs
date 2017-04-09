using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using System.Diagnostics;
using Tibox.Katana.Middleware;

namespace Tibox.Katana
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();
            WebApiConfig.Register(configuration);

            //Implementación de Middleware

            app.UseDebugMiddleware();

            app.UseWebApi(configuration);
        }
    }
}
