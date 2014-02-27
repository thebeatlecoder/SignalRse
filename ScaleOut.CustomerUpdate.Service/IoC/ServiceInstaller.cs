using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ScaleOut.CustomerUpdates;
using ScaleOut.CustomerUpdates.Interfaces;

namespace ScaleOut.CustomerUpdate.Service.IoC
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IHandleCustomerUpdates>()
                                        .ImplementedBy<CustomerUpdateService>()
                                        .LifestyleTransient());
        }
    }
}