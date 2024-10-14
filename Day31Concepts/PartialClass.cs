using System;

namespace Day31Concepts.PartialClass
{
    public partial class HelloWorld
    {
        public void HelloWordl() => Console.WriteLine("Hello World");

    }

    public partial class HelloWorld
    {
        public void HelloUniverse() => Console.WriteLine("Hello Universe");
    }

    public partial class Person
    {
        public string FirstName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
    }

    public partial class Person
    {
        public string LastName { get; set; }

        public void DisplayLastName()
        {
            Console.WriteLine($"Last Name: {LastName}");
        }
    }
}
