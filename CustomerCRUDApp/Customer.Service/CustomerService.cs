using Customers.Model;
using CustomersRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Service
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public List<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }

        public void Add(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            _customerRepository.DeleteCustomer(id);
        }

        public void EditCustomer(Customer customer)
        {
            _customerRepository.EditCustomer(customer);
        }

        public Customer GetCustomer(int id)
        {
            return _customerRepository.GetCustomer(id);
        }
    }
}
