﻿using Owasp.AppSensor.Demo.Api.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace Owasp.AppSensor.Demo.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional },
                constraints: null,
                handler: new UsageHandler() { InnerHandler = new HttpControllerDispatcher(config) }
            );



            config.MessageHandlers.Add(new CustomHandler());
        }
    }
}
