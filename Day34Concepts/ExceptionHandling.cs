using System;

namespace Day34Concepts.ExceptionHandling
{
    public class Examples
    {
        public void ExceptionHandlingExample()
        {
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Enter Num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num 2");
            num2 = int.Parse(Console.ReadLine());

            try
            {
                int ouput = num1 / num2;
                Console.WriteLine(ouput);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error has happend please contact support");
            }
        }

        public void DivideByZeroException()
        {
            try
            {
                int firstNumber = 10;
                int secondNumber = 0;
                int result = firstNumber / secondNumber;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void CatchingMultipleExceptions()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[2]); 

                string userText = null;
                Console.WriteLine(userText.Length); 
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Index Error: {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Null Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // General catch block for any other exception
                Console.WriteLine($"General Error: {ex.Message}");
            }
        }

        public void ThrowingExceptions()
        {
            try
            {
                ValidateAge(-5);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
        }

        static void ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative.");
            }
            Console.WriteLine("Age is valid.");
        }
    }
}
