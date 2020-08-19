using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api_embuarama.Controllers.User
{
    public class apiUserController : ApiController
    {
        [HttpGet]
        [Route("v1/api/github/")]
        public HttpResponseMessage Register()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new { valid = false, message = "E-mail ou senha incorretos!" });
        }
    }
}
