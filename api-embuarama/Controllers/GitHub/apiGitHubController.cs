using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api_embuarama.Controllers.GitHub
{
    public class apiGitHubController : ApiController
    {
        [HttpGet]
        [Route ("v1/api/github/")]
        public string Test()
        {
            return "Oi";
        }

    }
}
