using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Owasp.AppSensor.Demo.Api.Controllers
{
    [RoutePrefix("api/book")]
    public class BookController : ApiController
    {
        public List<string> GetBooks()
        {
            return new List<string>()
            {
                "Great Gatsby",
                "Anumal Farm",
                "The Catcher in the Rye"
            };
        }
    }
}
