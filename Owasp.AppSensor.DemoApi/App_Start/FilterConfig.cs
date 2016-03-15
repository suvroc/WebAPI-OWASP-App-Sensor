using System.Web;
using System.Web.Mvc;

namespace Owasp.AppSensor.DemoApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
