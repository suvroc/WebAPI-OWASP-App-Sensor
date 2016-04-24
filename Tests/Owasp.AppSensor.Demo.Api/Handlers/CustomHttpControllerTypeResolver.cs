using System;
using System.Diagnostics.Contracts;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace Owasp.AppSensor.Demo.Api.Handlers
{
    public class CustomHttpControllerTypeResolver : DefaultHttpControllerTypeResolver
    {
        public CustomHttpControllerTypeResolver()
                : base()
        { }

        internal static bool IsHttpEndpoint(Type t)
        {
            Contract.Assert(t != null);
            return
            t != null &&
            t.IsClass &&
            t.IsVisible &&
            !t.IsAbstract &&
            typeof(IHttpController).IsAssignableFrom(t); //&&
            //HasValidControllerName(t);
        }
    }
}