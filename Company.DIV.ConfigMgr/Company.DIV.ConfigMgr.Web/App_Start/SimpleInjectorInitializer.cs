using SimpleInjector;
using SimpleInjector.Extensions;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using Company.DIV.ConfigMgr.Domain;
using Company.DIV.ConfigMgr.Data;


//WebActivator is a NuGet package that allows other packages to easily bring in Startup and Shutdown code into a web application.
//  This gives a much cleaner solution than having to modify global.asax with the startup logic from many packages.
//PostApplicationStartMethod... http://blog.davidebbo.com/2011/02/new-features-in-webactivator-13.html
//http://stackoverflow.com/questions/5812596/what-does-webactivator-do
//http://haacked.com/archive/2010/05/16/three-hidden-extensibility-gems-in-asp-net-4.aspx/

//Pretty sure I simply don't need the WebActivator functionality here...
//[assembly: WebActivator.PostApplicationStartMethod(typeof(TestMVC.SimpleInjector.App_Start.SimpleInjectorInitializer) , "Initialize")]
namespace Company.DIV.ConfigMgr.Web
    {
    using System.Reflection;
    using System.Web.Mvc;

    //using SimpleInjector;
    //using SimpleInjector.Extensions;
    //using SimpleInjector.Integration.Web;
    //using SimpleInjector.Integration.Web.Mvc;
    
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
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
            //container.Register<IApp , App>(Lifestyle.Transient);
            //container.Register<IDAO<App> , AppDAO>(Lifestyle.Transient);
            //container.Register<IAppDAO , AppDAO>(Lifestyle.Transient);
            container.Register<AppDAO , AppDAO>(Lifestyle.Transient);

            }
        }
}