using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Tibox.Katana.Filters
{
    public class AuthorizationAttribute: AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            Debug.WriteLine($"Esta autenticado: "+
                $"{actionContext.RequestContext.Principal}");
            return true;
        }
    }
}