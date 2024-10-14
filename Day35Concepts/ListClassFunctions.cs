using Day35Concepts.Customers;
using Day35Concepts.CustomerTestData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day35Concepts.ListClassFunctions
{
    public class PredefinedMethods
    {
        public void ListClassConatinsMethod()
        {
            CustomerData customerObject = new CustomerData();

            List<Customer> listCustomers = customerObject.GetCustomers();
            Customer customer3 = listCustomers[2];

            if (listCustomers.Contains(customer3))
            {
                Console.WriteLine("Customer 3 is present");
            }
            else
            {
                Console.WriteLine("Customer 3 is not present");
            }
        }

        public void ContainsMethodForPrimitiveType()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine(numbers.Contains(3));
            Console.WriteLine(numbers.Contains(10));
        }

        public void ConatinsMetthodsForStrings()
        {
            List<string> names = new List<string> { "John", "Alice", "Bob" };

            Console.WriteLine(names.Contains("Alice"));
            Console.WriteLine(names.Contains("David"));
        }

        public void ListClassExsitsMethod()
        {
            CustomerData customerObject = new CustomerData();
            List<Customer> listCustomers = customerObject.GetCustomers();

            if (listCustomers.Exists(customer => customer.Name.StartsWith("S")))
            {
                Console.WriteLine("Name Starts with s");
            }
            else
            {
                Console.WriteLine("No name starts with s");
            }
        }

        public void ExistsMethodWithIntList()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            bool hasEvenNumber = numbers.Exists(num => num % 2 == 0);
            Console.WriteLine($"hasEvenNumber:{hasEvenNumber}");
        }

        public void ExistsMethodWithStringList()
        {
            List<string> names = new List<string> { "John", "Alice", "Bob", "Sam" };

            bool isStartsWithA = names.Exists(name => name.StartsWith("A"));
            Console.WriteLine($" Is Sttring starts with A :{isStartsWithA}");
        }

        public void ListClassFindMethods()
        {
            CustomerData customerObject = new CustomerData();
            List<Customer> listCustomers = customerObject.GetCustomers();

            Customer customer = listCustomers.Find(customer => customer.Salary > 4000);
            if (customer != null)
            {
                Console.WriteLine($"Id:{customer.Id}, Name:{customer.Name}, Salary:{customer.Salary}");
            }
            else
            {
                Console.WriteLine("No customer found with Salary > 5000");
            }

            Customer customer2 = listCustomers.FindLast(customer => customer.Salary > 3000);
            Console.WriteLine("\nBy FindLast");

            if (customer2 != null)
            {
                Console.WriteLine($"Id:{customer2.Id}, Name:{customer2.Name}, Salary:{customer2.Salary}");
            }
            else
            {
                Console.WriteLine("No customer found with Salary > 5000 (FindLast)");
            }
        }

        public void FindMethodForDoubleList()
        {
            List<double> prices = new List<double> { 19.99, 49.99, 29.99, 99.99, 15.99 };

            double firstPriceOver50 = prices.Find(price => price > 50.0);
            Console.WriteLine($"First price over 50: {firstPriceOver50}");

            double lastPriceUnder30 = prices.FindLast(price => price < 30.0);
            Console.WriteLine($"Last price under 30: {lastPriceUnder30}");
        }

        public void FindMethodForDateAndTimeList()
        {
            List<DateTime> eventDates = new List<DateTime>
        {
            new DateTime(2023, 1, 1),
            new DateTime(2023, 5, 15),
            new DateTime(2023, 10, 10),
            new DateTime(2024, 3, 25)
        };

            DateTime firstEventAfterJune = eventDates.Find(date => date > new DateTime(2023, 6, 1));
            Console.WriteLine($"First event after June 2023: {firstEventAfterJune.ToShortDateString()}");

            DateTime lastEventBefore2024 = eventDates.FindLast(date => date < new DateTime(2024, 1, 1));
            Console.WriteLine($"Last event before 2024: {lastEventBefore2024.ToShortDateString()}");
        }

        public void FindMethodForDictionary()
        {
            Dictionary<int, string> students = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" },
            { 4, "Diana" }
        };

            string firstStudent = new List<string>(students.Values).Find(name => name.StartsWith("C"));
            Console.WriteLine($"First student whose name starts with 'C': {firstStudent}");

            int lastStudentId = new List<int>(students.Keys).FindLast(id => id > 2);
            Console.WriteLine($"Last student ID greater than 2: {lastStudentId}, Name: {students[lastStudentId]}");
        }

        public void ListClassFindAllMethod()
        {
            CustomerData customerObject = new CustomerData();
            List<Customer> listCustomers = customerObject.GetCustomers();

            List<Customer> customers = listCustomers.FindAll(cust => cust.Salary > 3000);
            foreach (Customer c in customers)
            {
                Console.WriteLine($"Id:{c.Id},Name:{c.Name},Salary:{c.Salary}");
            }
        }

        public void FindAllForIntLists()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> evenNumbers = numbers.FindAll(num => num % 2 == 0);

            Console.WriteLine("Even numbers:");
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public void FindAllForDateAndTimeLists()
        {
            List<DateTime> eventDates = new List<DateTime>
        {
            new DateTime(2023, 1, 1),
            new DateTime(2023, 5, 15),
            new DateTime(2023, 10, 10),
            new DateTime(2024, 3, 25)
        };

            List<DateTime> eventsIn2023 = eventDates.FindAll(date => date.Year == 2023);

            Console.WriteLine("Events in 2023:");
            foreach (DateTime eventDate in eventsIn2023)
            {
                Console.WriteLine(eventDate.ToShortDateString());
            }
        }

        public void FindFirstAndLastIndexForListClass()
        {
            CustomerData customerObject = new CustomerData();
            List<Customer> listCustomers = customerObject.GetCustomers();

            int firstIndex = listCustomers.FindIndex(customer => customer.Salary > 3000);
            Console.WriteLine($"indexByFirst:{firstIndex}");

            int lastIndex = listCustomers.FindLastIndex(customer => customer.Salary > 3000);
            Console.WriteLine($"indexbyLast:{lastIndex}");
        }

        public void ArrayToLists()
        {
            CustomerData customerObject = new CustomerData();
            List<Customer> listCustomers = customerObject.GetCustomers();

            Customer[] customers = new Customer[3];
            customers[0] = listCustomers[0];
            customers[1]=listCustomers[1];
            customers[2]=listCustomers[2];

            List<Customer> toListCustomers = customers.ToList();
            foreach (Customer customer in toListCustomers)
            {
                Console.WriteLine($"Id:{customer.Id},Name:{customer.Name},Salary:{customer.Salary}");
            }
        }

        public void ListToDictionaryExample()
        {
            CustomerData customerObject = new CustomerData();
            List<Customer> listCustomers = customerObject.GetCustomers();

            Dictionary<int, Customer> customerDictionary = listCustomers.ToDictionary(customer => customer.Id);

            foreach (KeyValuePair<int, Customer> kvp in customerDictionary)
            {
                Console.WriteLine($"Key={kvp.Key}");
                Customer customer = kvp.Value;
                Console.WriteLine($"Id:{customer.Id},Name:{customer.Name},Salary:{customer.Salary}");
            }
        }

        public void ManagePersonData()
        {
            List<Person> people = new List<Person>
            {
                new Person { Id = 1, Name = "Alice", Age = 28, Balance = 1500.50m },
                new Person { Id = 2, Name = "Bob", Age = 35, Balance = 3400.75m },
                new Person { Id = 3, Name = "Charlie", Age = 22, Balance = 5000.00m },
                new Person { Id = 4, Name = "David", Age = 30, Balance = 3400.75m },
                new Person { Id = 5, Name = "Eve", Age = 26, Balance = 1200.00m }
            };
            // Find the first and last occurrence of a person with a specific balance
            Person firstPersonWithBalance = people.Find(person => person.Balance == 3400.75m);
            Person lastPersonWithBalance = people.FindLast(person => person.Balance == 3400.75m);
            Console.WriteLine("\nFirst person with balance 3400.75:");
            Console.WriteLine($"{firstPersonWithBalance.Name}, Balance: {firstPersonWithBalance.Balance}");

            Console.WriteLine("\nLast person with balance 3400.75:");
            Console.WriteLine($"{lastPersonWithBalance.Name}, Balance: {lastPersonWithBalance.Balance}");

            // Find the first and last index of people whose balance is greater than 2000
            int firstIndexHighBalance = people.FindIndex(person => person.Balance > 2000);
            int lastIndexHighBalance = people.FindLastIndex(person => person.Balance > 2000);
            Console.WriteLine($"\nFirst index of person with balance > 2000: {firstIndexHighBalance}");
            Console.WriteLine($"Last index of person with balance > 2000: {lastIndexHighBalance}");

            //Retrieve the first and last person whose age is greater than 25
            Person firstPersonWithAge = people.Find(person => person.Age > 25);
            Person lastPersonWithAge = people.FindLast(person => person.Age > 25);
            Console.WriteLine("\nFirst person with age > 25:");
            Console.WriteLine($"{firstPersonWithAge.Name}, Age: {firstPersonWithAge.Age}");

            Console.WriteLine("\nLast person with age > 25:");
            Console.WriteLine($"{lastPersonWithAge.Name}, Age: {lastPersonWithAge.Age}");

            //Find the first index and last index of a specific person object
            Person personToFind = people[3]; // David
            int firstIndex = people.IndexOf(personToFind);
            int lastIndex = people.LastIndexOf(personToFind);
            Console.WriteLine($"\nFirst index of David: {firstIndex}");
            Console.WriteLine($"Last index of David: {lastIndex}");

            //Retrieve all people with balance below 2000
            List<Person> lowBalancePeople = people.FindAll(person => person.Balance < 2000);
            Console.WriteLine("\nPeople with balance < 2000:");
            foreach (Person person in lowBalancePeople)
            {
                Console.WriteLine($"{person.Name}, Balance: {person.Balance}");
            }
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Balance { get; set; }
    }
}
