using Castle.Windsor;
using Castle.Windsor.Installer;
using ScaleOut.CustomerUpdates.Interfaces;
using Topshelf;

namespace ScaleOut.CustomerUpdate.Service
{
    public class Program
    {
        private static WindsorContainer _container;

        public static void Main(string[] args)
        {
            InstallEverythingInTheContainer();

            var service = CreateHost();
            service.Run();
        }

        private static Host CreateHost()
        {
            return HostFactory.New(host =>
            {
                host.Service<IHandleCustomerUpdates>(config =>
                {
                    config.ConstructUsing(settings => _container.Resolve<IHandleCustomerUpdates>());
                    config.WhenStarted(service => service.Start());
                    config.WhenContinued(service => service.Start());
                    config.WhenPaused(service => service.Stop());
                    config.WhenStopped(service => service.Stop());
                    config.AfterStoppingService(context => _container.Dispose());
                });
                host.SetDisplayName(AppSettings.ServiceDisplayName);
                host.SetServiceName(AppSettings.ServiceName);
            });
        }

        private static void InstallEverythingInTheContainer()
        {
            _container = new WindsorContainer();
            _container.Install(FromAssembly.This());
        }
    }
}
