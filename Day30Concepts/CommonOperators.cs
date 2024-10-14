using System;

namespace Day30Concepts.CommonOperators
{
    public class Operators
    {
        public void OperatorExampleforInt()
        {
            //assignment operator
            int numerator = 10;
            int denominator = 2;

            //Arithematic Operator
            Console.WriteLine($"Arithematic Operations for  {numerator} and  {denominator}");
            Console.WriteLine($"a+b::{numerator + denominator}, a-b::{numerator - denominator}, " +
                $"a*b::{numerator * denominator}, a/b::{numerator / denominator},a%b::{numerator % denominator}\n");

            //Comparison Operator
            Console.WriteLine($"Comparison Operations for  {numerator} and  {denominator}");
            Console.WriteLine($"a==b ::{numerator == denominator} a>b::{numerator > denominator}" +
                $" a<b::{numerator < denominator} a>=b::{numerator >= denominator}" +
                $" a<=b::{numerator <= denominator} a!=b::{numerator != denominator}\n");

            //Conditional Operator
            Console.WriteLine($"Conditional Operations for  {numerator} and {denominator}");
            Console.WriteLine($"a>b && a==5 :: {numerator > denominator && numerator == 5} " +
                $"a>b || a==5 :: {numerator > denominator || numerator == 5}\n");

            //Ternary Operator
            Console.WriteLine("Ternary Operator to check a is even or not");
            string isEven = numerator % 2 == 0 ? "a is even" : "a is odd";
            Console.WriteLine(isEven);
        }

        public void OperatorExampleForFloat()
        {
            // Assignment operator
            float numerator = 10.5f;
            float denominator = 2.3f;

            // Arithematic Operator
            Console.WriteLine($"Arithematic Operations for a {numerator} and b {denominator}");
            Console.WriteLine($"a+b::{numerator + denominator}, a-b::{numerator - denominator}," +
                $" a*b::{numerator * denominator}, a/b::{numerator / denominator}," +
                $"a%b::{numerator % denominator}\n");

            // Comparison Operator
            Console.WriteLine($"Comparison Operations for a {numerator} and b {denominator}");
            Console.WriteLine($"a==b ::{numerator == denominator}" +
                $" a>b::{numerator > denominator} a<b::{numerator < denominator} " +
                $"a>=b::{numerator >= denominator} a<=b::{numerator <= denominator}" +
                $" a!=b::{numerator != denominator}\n");

            // Conditional Operator
            Console.WriteLine($"Conditional Operations for a {numerator} and b {denominator}");
            Console.WriteLine($"a>b && a==5 :: {numerator > denominator && numerator == 5}" +
                $" a>b || a==5 :: {numerator > denominator || numerator == 5} \n");
        }

        public void OperatorExampleForDouble()
        {
            // Assignment operator
            double numerator = 15.78;
            double denominator = 3.56;

            // Arithematic Operator
            Console.WriteLine($"Arithematic Operations for a {numerator} and b {denominator}");
            Console.WriteLine($"a+b::{numerator + denominator}, a-b::{numerator - denominator}," +
                $" a*b::{numerator * denominator}, a/b::{numerator / denominator}," +
                $"a%b::{numerator % denominator} \n");

            // Comparison Operator
            Console.WriteLine($"Comparison Operations for a {numerator} and b {denominator}");
            Console.WriteLine($"a==b ::{numerator == denominator} a>b::{numerator > denominator}" +
                $" a<b::{numerator < denominator} a>=b::{numerator >= denominator}" +
                $" a<=b::{numerator <= denominator} a!=b::{numerator != denominator}\n");

            // Conditional Operator
            Console.WriteLine($"Conditional Operations for a {numerator} and b {denominator}");
            Console.WriteLine($"a>b && a==5 :: {numerator > denominator && numerator == 5} " +
                $"a>b || a==5 :: {numerator > denominator || numerator == 5} \n");
        }

        public void OperatorExampleForChar()
        {
            // Assignment operator
            char firstAlphabet = 'A';
            char secondAlphabet = 'B';

            // Arithematic Operator (no valid arithmetic operations for char)

            // Comparison Operator
            Console.WriteLine($"Comparison Operations for firstAlphabet {firstAlphabet} and secondAlphabet {secondAlphabet}");
            Console.WriteLine($"firstAlphabet==secondAlphabet ::{firstAlphabet == secondAlphabet} " +
                $"firstAlphabet>secondAlphabet::{firstAlphabet > secondAlphabet} firstAlphabet<secondAlphabet::{firstAlphabet < secondAlphabet} " +
                $"firstAlphabet>=secondAlphabet::{firstAlphabet >= secondAlphabet} firstAlphabet<=secondAlphabet::{firstAlphabet <= secondAlphabet} " +
                $"firstAlphabet!=secondAlphabet::{firstAlphabet != secondAlphabet}\n");

            // Conditional Operator (not typically used for char)
        }

        public void OperatorExampleForString()
        {
            // Assignment operator
            string firstWord = "Hello";
            string secondWord = "World";

            // Arithematic Operator (string concatenation)
            Console.WriteLine($"Arithematic Operations for firstWord {firstWord} and secondWord {secondWord}");
            Console.WriteLine($"firstWord+secondWord::{firstWord + " " + secondWord}\n");

            // Comparison Operator
            Console.WriteLine($"Comparison Operations for firstWord {firstWord} and secondWord {secondWord}");
            Console.WriteLine($"firstWord==secondWord ::{firstWord == secondWord} firstWord!=secondWord::{firstWord != secondWord}\n");
        }

        /// <summary>
        /// coalescing operator returns first non-null value from the chain
        /// </summary>
        public void NullCoalesingOperatorExample()
        {
            string firstWord = null;
            string secondWord = null;
            string thirdWord = null;
            string fourthWord = "Word4";

            string finalWord = firstWord ?? secondWord ?? thirdWord ?? fourthWord;
            Console.WriteLine(finalWord);
        }

        public void PrintNameUsingNullCoelascing()
        {
            string firstName = "Marry";
            string middleName = null;
            string lastName = "John";

            string fullName = firstName + (middleName ?? "") + lastName;

            Console.WriteLine($"Name is {fullName}");
        }
    }
}
