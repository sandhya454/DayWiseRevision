using Day35Concepts.Customers;
using Day35Concepts.CustomerTestData;
using System;
using System.Collections.Generic;

namespace Day35Concepts.ListOfComplexTypes
{
    public class ComplexTypesExamples
    {
        public void SortMethodForComplexType()
        {
            CustomerData customerObject = new CustomerData();

            List<Customer> retailCustomers = customerObject.GetRetailCustomers();
            List<Customer> corporateCustomer = customerObject.GetCorporateCustomer();
            retailCustomers.AddRange(corporateCustomer);

            Console.WriteLine("Before sorting salary");
            foreach (Customer customer in retailCustomers)
            {
                Console.WriteLine(customer.Salary);
            }

            retailCustomers.Sort();
            Console.WriteLine("After sorting salary");
            foreach (Customer customer in retailCustomers)
            {
                Console.WriteLine(customer.Salary);
            }

            SortByName sortByName = new SortByName();
            retailCustomers.Sort(sortByName);

            Console.WriteLine("\nBy using Sort By Name Class:");
            foreach (Customer customer in retailCustomers)
            {
                Console.WriteLine(customer.Name);
            }

            Console.WriteLine("Before sorting Type");
            foreach (Customer customer in retailCustomers)
            {
                Console.WriteLine(customer.Type);
            }

            SortByType sortByType = new SortByType();
            retailCustomers.Sort(sortByType);

            Console.WriteLine("After sorting Type");
            foreach (Customer customer in retailCustomers)
            {
                Console.WriteLine(customer.Type);
            }
        }

        public void SortMethodForDateAndTime()
        {
            List<Event> events = new List<Event>
            {
                new Event { Name = "Event 1", Date = new DateTime(2023, 12, 1) },
                new Event { Name = "Event 2", Date = new DateTime(2022, 6, 15) },
                new Event { Name = "Event 3", Date = new DateTime(2024, 1, 10) }
            };

            EventDateComparer eventDateComparer = new EventDateComparer();
            events.Sort(eventDateComparer);
            foreach (Event date in events)
            {
                Console.WriteLine(date.Date);
            }
        }

        public void SortMethodForCustomObject()
        {
            List<Book> books = new List<Book>
            {
                new Book { Title = "Book A", Author = new Author { Name = "John" } },
                new Book { Title = "Book B", Author = new Author { Name = "Alice" } },
                new Book { Title = "Book C", Author = new Author { Name = "Bob" } }
            };

            BookAuthorComparer bookAuthorComparer = new BookAuthorComparer();
            books.Sort(bookAuthorComparer);
            Console.WriteLine("After sorting Name");
            foreach (Book author in books)
            {
                Console.WriteLine(author.Author.Name);
            }
        }
    }

    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }

    public class EventDateComparer : IComparer<Event>
    {
        public int Compare(Event x, Event y)
        {
            // Compare by Date
            return x.Date.CompareTo(y.Date);
        }
    }

    public class Author
    {
        public string Name { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
    }

    public class BookAuthorComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            // Compare based on Author's Name
            return x.Author.Name.CompareTo(y.Author.Name);
        }
    }
}
