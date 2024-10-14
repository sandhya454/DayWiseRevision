using System;
using System.Collections.Generic;

namespace Day35Concepts.ListOfSimpleTypes
{
    public class SimpleTypeExamples
    {
        public void MethodForIntegerLists()
        {
            List<int> numbers = new List<int>() { 1, 7, 5, 8, 10, 4, 8 };
            Console.WriteLine("Numbers before sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();
            Console.WriteLine("\nNumbers after Sorting:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Reverse();
            Console.WriteLine("\nNumbers in Descending Order:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void MethodForStringLists()
        {
            List<string> alphabets = new List<string>() { "M", "A", "N", "I", "C", "Q" };
            Console.WriteLine("alphabets before sorting");
            foreach (string a in alphabets)
            {
                Console.WriteLine(a);
            }

            alphabets.Sort();
            Console.WriteLine("\nNumbers after Sorting:");
            foreach (string a in alphabets)
            {
                Console.WriteLine(a);
            }

            alphabets.Reverse();
            Console.WriteLine("\nNumbers in Descending Order:");
            foreach (string a in alphabets)
            {
                Console.WriteLine(a);
            }
        }

        public void MethodForBoolList()
        {
            List<bool> boolList = new List<bool> { true, false, true, false, true };

            boolList.Sort();
            Console.WriteLine("Sorted bool list (ascending):");
            foreach (var item in boolList)
            {
                Console.WriteLine(item);
            }

            boolList.Reverse();
            Console.WriteLine("Reversed bool list:");
            foreach (var item in boolList)
            {
                Console.WriteLine(item);
            }
        }

        public void MethodForDateAndTimeList()
        {
            List<DateTime> dateList = new List<DateTime>
            {
                new DateTime(2021, 12, 15),
                new DateTime(2020, 1, 1),
                new DateTime(2022, 5, 10),
                new DateTime(2019, 8, 20)
            };

            // Sorting in ascending order (earliest to latest)
            dateList.Sort();
            Console.WriteLine("Sorted DateTime list (ascending):");
            foreach (var date in dateList)
            {
                Console.WriteLine(date.ToString("yyyy-MM-dd"));
            }

            // Reversing the list
            dateList.Reverse();
            Console.WriteLine("Reversed DateTime list:");
            foreach (var date in dateList)
            {
                Console.WriteLine(date.ToString("yyyy-MM-dd"));
            }

            // Sorting in descending order (latest to earliest)
            dateList.Sort((x, y) => y.CompareTo(x));
            Console.WriteLine("Sorted DateTime list (descending):");
            foreach (var date in dateList)
            {
                Console.WriteLine(date.ToString("yyyy-MM-dd"));
            }
        }
    }
}
