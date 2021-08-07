using Customers.Model;
using System.Collections.Generic;

namespace Customers.Service
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void DeleteCustomer(int id);
        void EditCustomer(Customer customer);
        Customer GetCustomer(int id);
        List<Customer> GetCustomers();
    }
}