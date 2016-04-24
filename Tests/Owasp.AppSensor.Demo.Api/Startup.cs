using System.Web.Http;
using Microsoft.Owin;
using Owin;
using System.Web.Http.Dispatcher;
using Owasp.AppSensor.Demo.Api.Handlers;

[assembly: OwinStartup(typeof(Owasp.AppSensor.Demo.Api.Startup))]
namespace Owasp.AppSensor.Demo.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration httpConfiguration = new HttpConfiguration();

            httpConfiguration.Services
                .Replace(typeof(IAssembliesResolver), new MyAssembliesResolver());
            WebApiConfig.Register(httpConfiguration);
            app.UseWebApi(httpConfiguration);
        }
    }
}