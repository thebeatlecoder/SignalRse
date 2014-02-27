using System.Collections.Generic;

namespace ScaleOut.CustomerQuery.Contracts
{
    public interface IQueryCustomers
    {
        IEnumerable<Customer> GetAllCustomers();
    }
}