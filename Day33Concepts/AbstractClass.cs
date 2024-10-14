using System;

namespace Day33Concepts.AbstractClass
{
    public abstract class RegularCustomer
    {
        public abstract void Print();

    }

    public class Customer : RegularCustomer
    {
        public override void Print()
        {
            Console.WriteLine("Print Method in Abstract Class");
        }
    }

    abstract class Employee
    {
        public string Name { get; set; }

        public abstract double CalculateSalary();

        public abstract string Position { get; }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name}, Position: {Position}");
        }
    }

    class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        public override string Position
        {
            get { return "Full-Time Employee"; }
        }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    class PartTimeEmployee : Employee
    {
        public double HourlyWage { get; set; }
        public int HoursWorked { get; set; }

        public override string Position
        {
            get { return "Part-Time Employee"; }
        }

        public override double CalculateSalary()
        {
            return HourlyWage * HoursWorked;
        }
    }
}
