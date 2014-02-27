using Microsoft.AspNet.SignalR;
using ScaleOut.Event.Contracts;

namespace ScaleOut.Website.Hubs
{
    public class CustomerUpdateHub : Hub
    {
        public void Publish(CustomerSurnameUpdatedEvent customerSurnameUpdated)
        {
            Clients.All.subscribeTo(customerSurnameUpdated);
        }
    }
}