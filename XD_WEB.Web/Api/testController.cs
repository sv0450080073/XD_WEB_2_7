using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace XD_WEB.Web.Api
{
    public class testController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value 1", "value 2" };

        }
    }
}
