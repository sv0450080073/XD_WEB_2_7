using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XD_WEB.Service;
using XD_WEB.Web.Infrastructure.Core;

namespace XD_WEB.WEB1.Api
{
    [RoutePrefix("api/home")]

    public class HomeController : ApiControllerBase
    {
        IErrorService _errorService;
        public HomeController(IErrorService errorService) : base(errorService)
        {
            this._errorService = errorService;
        }

        [HttpGet]
        [Route("TestMethod")]
        public string TestMethod()
        {
            return "Hello, XD_WEB Member. ";
        }
    }
}
