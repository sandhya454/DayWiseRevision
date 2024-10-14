using Day35Concepts.Customers;
using System.Collections.Generic;

namespace Day35Concepts.CustomerTestData
{
    public class CustomerData
    {
        public List<Customer> GetCustomers()
        {
            Customer customer1 = new Customer() { Id = 1, Name = "John", Salary = 2000 };
            Customer customer2 = new Customer() { Id = 2, Name = "Peter", Salary = 4300 };
            Customer customer3 = new Customer() { Id = 3, Name = "Marry", Salary = 5000 };

            List<Customer> customers = new List<Customer>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            return customers;
        }

        public List<Customer> GetRetailCustomers()
        {
            Customer customer1 = new Customer() { Id = 101, Name = "John", Salary = 2000, Type = "A-Retail Customer" };
            Customer customer2 = new Customer() { Id = 22, Name = "Peter", Salary = 4300, Type = "E-Retail Customer" };
            Customer customer3 = new Customer() { Id = 13, Name = "Marry", Salary = 5000, Type = "F-Retail Customer" };

            List<Customer> customers = new List<Customer>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            return customers;
        }

        public List<Customer> GetCorporateCustomer()
        {
            Customer customer1 = new Customer() { Id = 24, Name = "Bob", Salary = 6000, Type = "K-Corporate Customer" };
            Customer customer2 = new Customer() { Id = 45, Name = "Tom", Salary = 4300, Type = "C-Corporate Customer" };
            Customer customer3 = new Customer() { Id = 16, Name = "Kim", Salary = 7000, Type = "M-Corporate Customer" };

            List<Customer> customers = new List<Customer>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            return customers;
        }
    }
}
