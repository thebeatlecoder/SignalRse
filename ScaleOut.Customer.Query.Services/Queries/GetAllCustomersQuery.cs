using System.Collections.Generic;
using ScaleOut.CustomerQuery.Contracts;

namespace ScaleOut.CustomerQuery.Services.Queries
{
    internal class GetAllCustomersQuery
    {
        internal IEnumerable<Customer> Execute()
        {
            var scott = new Customer {Id = 1, Forename = "Scott", Surname = "Smethurst"};
            var pervez = new Customer {Id = 2, Forename = "Pervez", Surname = "Choudhury"};
            var jamie = new Customer {Id = 3, Forename = "Jamie", Surname = "Reddell"};
            var diana = new Customer { Id = 4, Forename = "Diana", Surname = "Ionita" };
            var tony = new Customer {Id = 5, Forename = "Tony", Surname = "Reeve"};

            return new List<Customer> {scott, pervez, jamie, diana, tony};
        }
    }
}