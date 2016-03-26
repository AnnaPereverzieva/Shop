using System.Web.Mvc;
using System.Web.Routing;
using Shop.WebUI.Infrastructure;

namespace Shop.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Resolver.Configure();
        }
    }
}
