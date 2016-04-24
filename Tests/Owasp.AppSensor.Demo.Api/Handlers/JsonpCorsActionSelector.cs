using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;

namespace Owasp.AppSensor.Demo.Api.Handlers
{
    public class JsonpCorsActionSelector : ApiControllerActionSelector
    {
        private static readonly string HttpMethodQueryParameter = "httpMethod";

        public override HttpActionDescriptor SelectAction(HttpControllerContext controllerContext)
        {
            string httpMethod = controllerContext.Request.RequestUri.ParseQueryString()[HttpMethodQueryParameter];
            if (httpMethod != null)
            {
                HttpRequestMessage originalRequest = controllerContext.Request;
                HttpRequestMessage modifiedRequest = new HttpRequestMessage(
                                    new HttpMethod(httpMethod),
                                    originalRequest.RequestUri);
                controllerContext.Request = modifiedRequest;
                HttpActionDescriptor actualDescriptor = base.SelectAction(controllerContext);
                controllerContext.Request = originalRequest;
                return new DelegatingActionDescriptor(httpMethod, actualDescriptor);
            }
            return base.SelectAction(controllerContext);
        }
    }
}