using System;

namespace Day31Concepts.ClassIntroduction
{
    public class Customer
    {
        string _firstName;
        string _lastName;

        public Customer():this("no firstName Provided","no Lastname Provided")
        {
        }

        public Customer(string firstName,string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Full Name is {this._firstName} {this._lastName}");
        }

        ~Customer() { }
    }
}
