using Day35Concepts.Customers;
using System;
using System.Collections.Generic;
using Day35Concepts.CustomerTestData;

namespace Day35Concepts.ComparisonDeligateWithLists
{
    public class DeligateExamples
    {
        public void SortByUsingDeligate()
        {
            CustomerData customerObject = new CustomerData();

            List<Customer> retailCustomers = customerObject.GetRetailCustomers();
            List<Customer> corporateCustomer = customerObject.GetCorporateCustomer();
            retailCustomers.AddRange(corporateCustomer);

            Console.WriteLine("Before Sorting");
            foreach (Customer customer in retailCustomers)
            {
                Console.WriteLine(customer.Id);
            }

            retailCustomers.Sort((customer1, customer2) => customer1.Id.CompareTo(customer2.Id));
            // retailCustomers.Sort(delegate (Customer c1, Customer c2) { return c1.Id.CompareTo(c2.Id); });

            Console.WriteLine("\nAfter Sorting");
            foreach (Customer customer in retailCustomers)
            {
                Console.WriteLine(customer.Id);
            }

            Console.WriteLine("Before Sorting BY Name");
            foreach (Customer customer in retailCustomers)
            {
                Console.WriteLine(customer.Name);
            }

            retailCustomers.Sort((customer1, customer2) => customer1.Name.CompareTo(customer2.Name));

            Console.WriteLine("\nAfter Sorting");
            foreach (Customer customer in retailCustomers)
            {
                Console.WriteLine(customer.Name);
            }
        }

        public void ReverseOrderSortingUsingDeligate()
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 10},
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Charlie", Age = 26 }
            };

            Console.WriteLine("Before Sorting BY Age");
            foreach(Person person in people )
            {
                Console.WriteLine(person.Age);
            }

            // Sort by Age in descending order using lambda expression
             people.Sort((x, y) => y.Age.CompareTo(x.Age));

            Console.WriteLine("\nAfter Sorting BY Age");
            foreach(Person person in people)
            {
                Console.WriteLine(person.Age);
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
