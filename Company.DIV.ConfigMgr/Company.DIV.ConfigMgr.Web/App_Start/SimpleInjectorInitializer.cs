using SimpleInjector;
using SimpleInjector.Extensions;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using Company.DIV.ConfigMgr.DataRead;

namespace Company.DIV.ConfigMgr
    {
    using System.Reflection;
    using System.Web.Mvc;

    public static class SimpleInjectorInitializer
    {
        public static void Initialize()
            {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            }
     
        private static void InitializeContainer(Container container)
            {
            container.Register<AppDAO , AppDAO>(Lifestyle.Scoped); //bc using IDisposable - Otherwise use Lifestyle.Transient
            }

        }
}