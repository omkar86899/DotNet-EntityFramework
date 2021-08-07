using Customers.Model;
using System.Collections.Generic;

namespace CustomersRepository
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        void DeleteCustomer(int id);
        void EditCustomer(Customer customer);
        Customer GetCustomer(int id);
        List<Customer> GetCustomers();
    }
}