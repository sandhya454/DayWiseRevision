using System;
using System.Collections.Generic;

namespace Day37Concepts.ExtensionMethods
{
    public class Examples
    {
        public void ChangeStringFirstLetter()
        {
            string name = "peter";
            string result = name.ChangeFirstLetterCase();

           // string result = StringHelper.ChangeFirstLetterCase(name);

            Console.WriteLine(result);

        }

        public void CheckingPalindrome()
        {
            string word = "Madam";
            bool isPalindrome = word.IsPalindrome();

            Console.WriteLine($"{word} is Palindrome:{isPalindrome}");
        }

        public void CheckingNumberIsEven()
        {
            int number = 4;

            bool isEven = number.IsEven();

            Console.WriteLine($"the given number {number} is even :{isEven}");
        }

        public  void FindSecondLargestNumber()
        {
            var numbers = new List<int> { 4, 1, 7, 7, 3 };
            int secondLargest = numbers.SecondLargest();

            Console.WriteLine($"The second Largest Number in the list is {secondLargest}");
        }
    }
}
