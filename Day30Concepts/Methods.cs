using System;
using System.Collections.Generic;

namespace Day30Concepts.Methods
{
    public class MethodExamples
    {
        public static void StaticMethod()
        {
            Console.WriteLine("This is static method no need to create instance");
        }

        public int Add(int firstNumber,int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public string PrintName()
        {
            string firstName = "john";
            string lastName = "mark";

            return firstName + lastName;
        }

        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius; 
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public List<string> GetNames()
        {
            List<string> names = new List<string>();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");
            return names;
        }
    }
}
