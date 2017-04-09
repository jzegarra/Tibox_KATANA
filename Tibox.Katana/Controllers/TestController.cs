using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tibox.Katana.Filters;

namespace Tibox.Katana.Controllers
{
    public class TestController : ApiController
    {
        
        [Authorization]
        [AuthenticationFilter]
        public IHttpActionResult Get()
        {
            Debug.WriteLine($"Ingreso al controlador: {User}");
            return Ok();
        }
    }
}
