using ConsoleEFApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEFApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer customer, customer1, customer2, customer3, customer4;
            AurionProDBContext db = new AurionProDBContext();

            customer1 = new Customer { Id = 1001, Location = "thane", Name = "omkar" };
            customer2 = new Customer { Id = 1002, Location = "mumbai", Name = "sachin" };
            customer3 = new Customer { Id = 1003, Location = "dadar", Name = "rahul" };
            customer4 = new Customer { Id = 1004, Location = "pune", Name = "prateek" };


            //CREATE
            //db.Customers.Add(customer1);
            //db.Customers.Add(customer2);
            //db.Customers.Add(customer3);
            //db.Customers.Add(customer4);
            //db.SaveChanges();

            //RETRIEVE
            PrintAllCustomerDetails(db.Customers);

            ////Update
            //customer = db.Customers.Where(c => c.Name == "sachin").First();
            //customer.Location = "pune";
            //db.SaveChanges();

            //Console.WriteLine("\nAfter Updating: ");
            //PrintAllCustomerDetails(db.Customers);

            ////Delete
            //customer = db.Customers.Where(c => c.Name == "sachin").First();
            //db.Customers.Remove(customer);
            //db.SaveChanges();

            //Console.WriteLine("\nAfter Deleting");
            //PrintAllCustomerDetails(db.Customers);

            //IEnumerable<Customer> enumerableCustomers = db.Customers.Where(c => c.Name.Length > 2);
            //enumerableCustomers = enumerableCustomers.Take(2);
            //IQueryable<Customer> querableCustomers = db.Customers.AsQueryable()
            //                                           .Where(c => c.Name.Length > 2);

            //querableCustomers = querableCustomers.Take(2);
            //Console.WriteLine("\nPrinting output of IEnumerable");
            //PrintAllCustomerDetails(enumerableCustomers);
            //Console.WriteLine("\nPrinting output of IQueryable");
            //PrintAllCustomerDetails(querableCustomers);

        }

        private static void PrintAllCustomerDetails(IEnumerable<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Id: " + customer.Id);
                Console.WriteLine("Name: " + customer.Name);
                Console.WriteLine("Location: " + customer.Location);
                Console.WriteLine("Balance: " + customer.Balance);
                Console.WriteLine("Type: " + customer.Type);
            }
        }

        private static void PrintAllCustomerDetails(DbSet<Customer> customers)
        {
            foreach(Customer customer in customers)
            {
                Console.WriteLine("Id: " + customer.Id);
                Console.WriteLine("Name: " + customer.Name);
                Console.WriteLine("Location: " + customer.Location);
                Console.WriteLine("Balance: " + customer.Balance);
                Console.WriteLine("Type: " + customer.Type);
            }
        }
    }
}
