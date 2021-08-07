using Customers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        private AurionProDBCotext _aurionProDBContext;
        public CustomerRepository()
        {
            _aurionProDBContext = new AurionProDBCotext();
        }

        public List<Customer> GetCustomers()
        {
            return _aurionProDBContext.Customers.ToList();
        }

        public void AddCustomer(Customer customer)
        {
            _aurionProDBContext.Customers.Add(customer);
            _aurionProDBContext.SaveChanges();
        }

        public void EditCustomer(Customer customer)
        {
            Customer oldCustomer = _aurionProDBContext.Customers.Where(c => c.Id == customer.Id).First();

            oldCustomer.Name = customer.Name;
            oldCustomer.Location = customer.Location;
            oldCustomer.Type = customer.Type;
            oldCustomer.Balance = customer.Balance;
            _aurionProDBContext.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            Customer customer = _aurionProDBContext.Customers.Where(c => c.Id == id).First();
            _aurionProDBContext.Customers.Remove(customer);
            _aurionProDBContext.SaveChanges();
        }

        public Customer GetCustomer(int id)
        {
            return _aurionProDBContext.Customers.Where(c => c.Id == id).First();
        }
    }
}
