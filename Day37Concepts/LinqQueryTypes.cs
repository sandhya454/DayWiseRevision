using System;
using System.Collections.Generic;
using System.Linq;

namespace Day37Concepts.LinqQueryTypes
{
    public class QueryTypes
    {
        public void QuerySyntax()
        {
            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            var querySyntax = from number in numberList
                              where number > 2
                              select number;

            Console.WriteLine("Using Query Syntax");
            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void MethodSyntax()
        {
            List<int> numberList = new List<int>() { 1, 2, 4, 57, 7, 2, 3 };

            var methodSyntax = numberList.Where(number => number > 2);

            Console.WriteLine("Using Method Syntax");
            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void MixedSyntax()
        {
            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("Using Mixed Syntax");
            var mixedSyntax = (from number in numberList
                               select number).Max();

            Console.WriteLine($"Maximum value is :{mixedSyntax}");
        }
    }
}
