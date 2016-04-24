using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace Owasp.AppSensor.Demo.Api.Handlers
{
    public class BypassCacheSelector : DefaultHttpControllerSelector
    {
        private readonly HttpConfiguration _configuration;

        public BypassCacheSelector(HttpConfiguration configuration)
            : base(configuration)
        {
            _configuration = configuration;
        }

        public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            var assembly = Assembly.LoadFile("c:/myAssembly.dll");
            var types = assembly.GetTypes(); //GetExportedTypes doesn't work with dynamic assemblies
            var matchedTypes = types.Where(i => typeof(IHttpController).IsAssignableFrom(i)).ToList();

            var controllerName = base.GetControllerName(request);
            var matchedController =
                matchedTypes.FirstOrDefault(i => i.Name.ToLower() == controllerName.ToLower() + "controller");

            return new HttpControllerDescriptor(_configuration, controllerName, matchedController);
        }
    }
}