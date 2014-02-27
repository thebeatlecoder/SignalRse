using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.Windsor;
using Castle.Windsor.Installer;
using ScaleOut.Website.IoC;

namespace ScaleOut.Website
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private WindsorContainer _container;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            InitialiseContainer();
        }

        protected void Application_End()
        {
            _container.Dispose();
        }

        private void InitialiseContainer()
        {
            _container = new WindsorContainer();
            _container.Install(FromAssembly.This());

            var windsorControllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(windsorControllerFactory);
        }
    }
}