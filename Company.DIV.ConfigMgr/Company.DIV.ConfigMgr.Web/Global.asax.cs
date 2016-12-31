using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Company.DIV.ConfigMgr.Web
    {
    public class MvcApplication : System.Web.HttpApplication
        {
        protected void Application_Start()
            {
            SimpleInjectorInitializer.Initialize();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            }
        }
    }
