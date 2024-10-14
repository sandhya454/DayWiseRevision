using System;

namespace Day32Concepts.Inheritance
{
    public class Employee
    {
        public string firstName;
        public string lastName;

        public void PrintName()
        {
            Console.WriteLine($"Name of employee:{firstName + lastName}");
        }
    }

    public class  FullTimeEmployee:Employee
    {
        public int yearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public int hourlySalary;
    }

    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent class constructor called");
        }

        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ChildClass:ParentClass
    {
        public ChildClass():base("Derived class Controlling parent class")
        {
            Console.WriteLine("Child Class Constructor Called");
        }
    }
}
