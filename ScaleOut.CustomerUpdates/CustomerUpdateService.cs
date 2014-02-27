using System;
using System.Threading;
using ScaleOut.CustomerUpdates.Interfaces;
using ScaleOut.CustomerUpdates.Notifications;
using ScaleOut.Event.Contracts;

namespace ScaleOut.CustomerUpdates
{
    public class CustomerUpdateService : IHandleCustomerUpdates
    {
        public void Start()
        {
            var notifier = new CustomerUpdateNotifier();
            var surnames = new[] { "Crankshaw", "Hickinbotham", "Shufflebottom", "Glasscock", "Haggard" }; 
            var random = new Random();

            while (true)
            {
                int randomIndex = random.Next(0, surnames.Length - 1);
                string randomNewSurname = surnames[randomIndex];
                int randomCustomerId = random.Next(1, 5);

                var customerNameUpdated = new CustomerSurnameUpdatedEvent
                                              {
                                                  Id = randomCustomerId,
                                                  NewSurname = randomNewSurname  
                                              };

                notifier.Publish(customerNameUpdated);
                Thread.Sleep(5000);
            }
        }

        public void Stop()
        {
        }
    }
}