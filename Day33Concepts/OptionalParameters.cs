using System;
using System.Runtime.InteropServices;

namespace Day33Concepts.OptionalParameters
{
    public class ParameterArray
    {
        public void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine($"Sum is :{result}");
        }

        public void ConcatenateStrings(string firstString, string secondString, params object[] restOfStrings)
        {
            string result = firstString + secondString;

            if (restOfStrings != null)
            {
                foreach (var item in restOfStrings)
                {
                    if (item is string)
                    {
                        result += (string)item;
                    }
                }
            }
            Console.WriteLine($"Concatenated String: {result}");
        }
    }

    public class MethodOverloading
    {
        public void AddNumbers(int firstNumber, int secondNumber)
        {
            AddNumbers(firstNumber, secondNumber, null);
        }

        public void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine($"Result is :{result}");
        }

        public void CalculateArea(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area of the circle: {area}");
        }

        public void CalculateArea(double length, double width)
        {
            double area = length * width;
            Console.WriteLine($"Area of the rectangle: {area}");
        }

        public void CalculateArea(double baseLength, double height, bool isTriangle)
        {
            if (isTriangle)
            {
                double area = 0.5 * baseLength * height;
                Console.WriteLine($"Area of the triangle: {area}");
            }
        }
    }

    public class ParameterDefault
    {
        public void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers = null)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine($"Result is {result}");
        }

        public void Test(int a, int b = 20, int c = 30)
        {
            Console.WriteLine($"a : {a}");
            Console.WriteLine($"b : {b}");
            Console.WriteLine($"c : {c}");
        }
    }

    class OptionalAttributeClass
    {
        public void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine($"Result:{result}");
        }

        public void ConcatenateStrings(string firstString, string secondString, [Optional] string[] restOfStrings)
        {
            string result = firstString + secondString;

            if (restOfStrings != null)
            {
                foreach (string str in restOfStrings)
                {
                    result += str;
                }
            }
            Console.WriteLine($"Concatenated String: {result}");
        }

        public void CalculateTotalPrice(double basePrice, double taxRate, [Optional] double[] discounts)
        {
            double totalPrice = basePrice + (basePrice * taxRate / 100);

            if (discounts != null)
            {
                foreach (double discount in discounts)
                {
                    totalPrice -= discount;
                }
            }
            Console.WriteLine($"Total Price: {totalPrice}");
        }
    }
}
