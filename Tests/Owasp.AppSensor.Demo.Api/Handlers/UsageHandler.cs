using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Owasp.AppSensor.Demo.Api.Handlers
{
    public class UsageHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            //see extension method
            //http://www.strathweb.com/2013/05/retrieving-the-clients-ip-address-in-asp-net-web-api/
            //var ip = request.GetClientIpAddress();
            //log IP

            return base.SendAsync(request, cancellationToken);
        }
    }
}