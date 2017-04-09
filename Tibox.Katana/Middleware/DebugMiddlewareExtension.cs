using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tibox.Katana.Middleware
{
    public static class DebugMiddlewareExtension
    {
        public static void UseDebugMiddleware(this IAppBuilder app)
        {
            app.Use<DebugMiddleware>();
        }
    }
}