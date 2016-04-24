using System.Collections.Generic;
using System.Reflection;
using System.Web.Http.Dispatcher;

namespace Owasp.AppSensor.Demo.Api.Handlers
{
    public class MyAssembliesResolver : DefaultAssembliesResolver
    {
        public override ICollection<Assembly> GetAssemblies()
        {
            //ICollection<Assembly> baseAssemblies = base.GetAssemblies();
            //List<Assembly> assemblies = new List<Assembly>(baseAssemblies);
            //var controllersAssembly = Assembly.LoadFrom("c:/myAssymbly.dll");
            //baseAssemblies.Add(controllersAssembly);
            //return assemblies;
            return base.GetAssemblies();
        }
    }
}