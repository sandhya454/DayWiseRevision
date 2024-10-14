using System;

namespace Day32Concepts.MethodHiding
{
    public class Customer
    {
        public string firstName;
        public string lastName;

        public void PrintName()
        {
            Console.WriteLine($"Name is {firstName + lastName}");
        }
    }

    public class RegularCustomer : Customer
    {
        public new void PrintName()
        {
            Console.WriteLine($"Name is {firstName + lastName} -Regular Customer");
        }
    }
}
