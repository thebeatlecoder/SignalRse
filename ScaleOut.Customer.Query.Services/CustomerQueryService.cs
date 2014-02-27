using System.Collections.Generic;
using ScaleOut.CustomerQuery.Contracts;
using ScaleOut.CustomerQuery.Services.Queries;

namespace ScaleOut.CustomerQuery.Services
{
    public class CustomerQueryService : IQueryCustomers
    {
        public IEnumerable<Customer> GetAllCustomers()
        {
            var query = new GetAllCustomersQuery();
            return query.Execute();
        }
    }
}
