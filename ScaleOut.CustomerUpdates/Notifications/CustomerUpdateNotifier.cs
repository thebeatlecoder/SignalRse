using Microsoft.AspNet.SignalR.Client;
using ScaleOut.Event.Contracts;

namespace ScaleOut.CustomerUpdates.Notifications
{
    internal class CustomerUpdateNotifier
    {
        private readonly IHubProxy _hubProxy;

        internal CustomerUpdateNotifier()
        {
            var hubConnection = new HubConnection(AppSettings.CustomerUpdateHubUrl);
            _hubProxy = hubConnection.CreateHubProxy(AppSettings.CustomerUpdateHubName);

            hubConnection.Start().Wait();
        }

        internal void Publish(CustomerSurnameUpdatedEvent customerSurnameUpdated)
        {
            // TODO: Error handling
            _hubProxy.Invoke<CustomerSurnameUpdatedEvent>("Publish", customerSurnameUpdated);
        }
    }
}