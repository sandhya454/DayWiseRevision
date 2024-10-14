using System;
using System.Collections.Generic;
using System.Linq;

namespace Day34Concepts.ArrayComparisons
{
    public class Comparisons
    {
        public void ArrayComparisonMethodExample()
        {
            string[] daysOfWeekArray1 =
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturda"
            };

            string[] daysOfWeekArray2 =
           {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };
            //it will return false because it compare refence
            bool isEqual = daysOfWeekArray1 == daysOfWeekArray2;

            bool isArrayEqual = true;
            if (daysOfWeekArray1.Length == daysOfWeekArray2.Length)
            {
                for (int i = 0; i < daysOfWeekArray1.Length; i++)
                {
                    if (daysOfWeekArray1[i] != daysOfWeekArray2[i])
                    {
                        isArrayEqual = false;
                    }
                }
            }
            else
            {
                isArrayEqual = false;
            }

            if (isArrayEqual)
            {
                Console.WriteLine("Both arrays are Equal");
            }
            else
            {
                Console.WriteLine("Both arrays are not equal");
            }
        }

        public void ArrayComparisonByPredefined()
        {
            string[] daysOfWeekArray1 =
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };

            string[] daysOfWeekArray2 =
           {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };
            bool isSequenceEqual = daysOfWeekArray1.SequenceEqual(daysOfWeekArray2);
            Console.WriteLine($"isSquenceEqual={isSequenceEqual}");
        }

        public void ArrayComparisonPrimitiveTypes()
        {
            int[] array1 = { 1, 2, 3, 4 };
            int[] array2 = { 1, 2, 3, 4 };
            int[] array3 = { 4, 3, 2, 1 };

            bool areEqual = array1.SequenceEqual(array2);
            bool areNotEqual = array1.SequenceEqual(array3);

            Console.WriteLine($"Array1 and Array2 are equal: {areEqual}");
            Console.WriteLine($"Array1 and Array3 are equal: {areNotEqual}");
        }

        public void ArrayComparisonStrings()
        {
            string[] array1 = { "apple", "banana", "cherry" };
            string[] array2 = { "apple", "banana", "cherry" };
            string[] array3 = { "banana", "apple", "cherry" };

            bool areEqual = array1.SequenceEqual(array2);
            bool areNotEqual = array1.SequenceEqual(array3);

            Console.WriteLine($"Array1 and Array2 are equal: {areEqual}");
            Console.WriteLine($"Array1 and Array3 are equal: {areNotEqual}");
        }

        public void ArrayComparisonNullableTypes()
        {
            int?[] array1 = { 1, 2, null, 4 };
            int?[] array2 = { 1, 2, null, 4 };
            int?[] array3 = { 1, null, 2, 4 };

            bool areEqual = array1.SequenceEqual(array2);
            bool areNotEqual = array1.SequenceEqual(array3); 

            Console.WriteLine($"Array1 and Array2 are equal: {areEqual}");
            Console.WriteLine($"Array1 and Array3 are equal: {areNotEqual}");
        }

        public void ArrayComparisonComplexTypes()
        {
            Person[] array1 = {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 }
        };

            Person[] array2 = {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 }
        };

            Person[] array3 = {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Charlie", Age = 35 }
        };
            var comparer = new PersonComparer();

            bool areEqual = array1.SequenceEqual(array2,comparer); 
            bool areNotEqual = array1.SequenceEqual(array3,comparer);  

            Console.WriteLine($"Array1 and Array2 are equal: {areEqual}");
            Console.WriteLine($"Array1 and Array3 are equal: {areNotEqual}");
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }
            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }

            return x.Name == y.Name && x.Age == y.Age;
        }

        public int GetHashCode(Person obj)
        {
            if (obj == null)
            {
                return 0;
            }
            int ageHashCode = obj.Age.GetHashCode();
            int nameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();

            return ageHashCode ^ nameHashCode;
        }
    }
}
