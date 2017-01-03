using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using AlexaSkillsKit;

namespace as_alexa_csharp.Controllers
{
    public class AlexaController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage SampleSession()
        {
            var speechlet = new CSharpSpeechlet();
            return speechlet.GetResponse(Request);
        }
    }
}
