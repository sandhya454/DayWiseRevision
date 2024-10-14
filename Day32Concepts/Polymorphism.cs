using System;

namespace Day32Concepts.Polymorphism
{
    public class Department
    {
        public string firstName = "First Name";
        public string lastName = "Last Name";

        public virtual void PrintName()
        {
            Console.WriteLine($"Name is {firstName} {lastName}");
        }
    }

    public class Electrical:Department
    {
        public override void PrintName()
        {
            Console.WriteLine($"Name is {firstName} {lastName} from Electrical");
        }
    }

    public class Computers:Department
    {
        public override void PrintName()
        {
            Console.WriteLine($"Name is {firstName} {lastName} from Computers");
        }
    }

    public class Mechanical:Department
    {
        public override void PrintName()
        {
            Console.WriteLine($"Name is {firstName} {lastName} from Mechanical");
        }
    }

    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle.");
        }
    }

    public class Employee
    {
        public string firstName = "FN";
        public string lastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " " + "FullTime");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " " + "PartTime");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " " + "Temporary");
        }
    }
}
