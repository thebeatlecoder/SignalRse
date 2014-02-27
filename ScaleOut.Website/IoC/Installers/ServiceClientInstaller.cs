using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ScaleOut.CustomerQuery.Contracts;
using ScaleOut.CustomerQuery.Services;

namespace ScaleOut.Website.IoC.Installers
{
    public class ServiceClientInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IQueryCustomers>()
                                        .ImplementedBy<CustomerQueryService>()
                                        .LifestyleTransient());
        }
    }
}