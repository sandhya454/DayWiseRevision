using System;
using System.Collections.Generic;
using Day35Concepts.Customers;
using Day35Concepts.CustomerTestData;

namespace Day35Concepts.ListCollectionClass
{
    public class CollectionClassExample
    {
        public void ListCollectionMethod()
        {
            CustomerData customerObject = new CustomerData();

            List<Customer> customers = customerObject.GetCustomers();
            Customer customer3 = customers[2];

            //to get index
            Console.WriteLine(customers.IndexOf(customer3));
            Console.WriteLine(customers.IndexOf(customer3, 1));
            Console.WriteLine(customers.IndexOf(customer3, 1, 2));

            //iterate list by using foreach loop
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Id:{customer.Id},Name:{customer.Name},Salary:{customer.Salary}");
            }

            //iterate list by using for loop
            for (int i = 0; i < customers.Count; i++)
            {
                Customer customer = customers[i];
                Console.WriteLine($"Id:{customer.Id},Name:{customer.Name},Salary:{customer.Salary}");
            }

            SavingsCustomer savingsCustomer = new SavingsCustomer();
            customers.Add(savingsCustomer);
        }
    }

    public class SavingsCustomer : Customer
    {

    }
}
    
