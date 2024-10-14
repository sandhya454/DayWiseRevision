using System.Linq;
using System;
using System.Collections.Generic;

namespace Day37Concepts
{
    public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string input)
        {
            if (input.Length > 0)
            {
                char[] charArray = input.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }
            return input;
        }

        public static bool IsPalindrome(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            string reversed = new string(input.Reverse().ToArray());
            return string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
    public static class IntExtensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }

    public static class ListExtensions
    {
        public static T SecondLargest<T>(this List<T> list) where T : IComparable<T>
        {
            if (list.Count < 2) throw new InvalidOperationException("List must contain at least two elements.");

            var distinctList = list.Distinct().OrderByDescending(x => x).ToList();
            return distinctList[1];
        }
    }
}
