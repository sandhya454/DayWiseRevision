using System;

namespace Day32Concepts
{
    public class MethodOverloading
    {
        public void Add(int firstNumber, int secondNumber)
        {
           Console.WriteLine( firstNumber + secondNumber);
        }

        public void Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine(firstNumber + secondNumber + thirdNumber);
        }

        public void Add(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }

        public void Add(string firstWord, string secondWord)
        {
            Console.WriteLine(firstWord + secondWord);
        }

        public void Display(int number, string message)
        {
            Console.WriteLine($"Integer: {number}, Message: {message}");
        }

        public void Display(string message, int number)
        {
            Console.WriteLine($"Message: {message}, Integer: {number}");
        }
    }
}
