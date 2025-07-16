using System.Web.Mvc;
using System.Web.Optimization; // Needed for bundles
using System.Web.Routing;

namespace FuzzyNinjectWarrior
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles); // If you use bundles

            // Ninject setup is typically handled in App_Start/NinjectWebCommon.cs
            // If not, add your dependency resolver initialization here.
        }
    }
}
