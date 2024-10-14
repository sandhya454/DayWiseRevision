using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Day35Concepts.GeniricQueue
{
    public class QueueExample
    {
        public void QueueMethodExample()
        {
            MovieTicketBookingSystem bookingSystem = new MovieTicketBookingSystem();
            bookingSystem.AddToQueue(new Customer { Name = "John", Age = 39 });
            bookingSystem.AddToQueue(new Customer { Name = "Marry", Age = 20 });
            bookingSystem.AddToQueue(new Customer { Name = "Mark", Age = 29 });

            bookingSystem.ShowQueue();

            Console.WriteLine("\n Booking Process Started");
            bookingSystem.ProcessingBooking();
            bookingSystem.ProcessingBooking();

            bookingSystem.ShowQueue();

            Console.WriteLine("Adding More Customer to the Queue:");
            bookingSystem.AddToQueue(new Customer { Name = "Sam", Age = 24 });
            bookingSystem.AddToQueue(new Customer { Name = "Peter", Age = 26 });

            bookingSystem.ShowQueue();

            Console.WriteLine("\n Booking Process Started");
            bookingSystem.ProcessingBooking();
            bookingSystem.ProcessingBooking();

            bookingSystem.ShowQueue();
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class MovieTicketBookingSystem
    {
        Queue<Customer> _queue;
        public MovieTicketBookingSystem()
        {
            _queue = new Queue<Customer>();
        }

        public void AddToQueue(Customer customer)
        {
            _queue.Enqueue(customer);
            Thread.Sleep(1000);
            Console.WriteLine($"Added to Queue:{customer.Name}");
        }

        public void ProcessingBooking()
        {
            if (_queue.Any())
            {
                var customer = _queue.Dequeue();
                Thread.Sleep(1000);
                Console.WriteLine($"Processed for Booking : {customer.Name}");
            }
        }

        public void ShowQueue()
        {
            Console.WriteLine("\n\t Current Queue");
            Console.WriteLine("\t -------");
            foreach (var customer in _queue)
            {
                Thread.Sleep(500);
                Console.WriteLine("\t" + customer.Name);
            }
        }
    }
}
