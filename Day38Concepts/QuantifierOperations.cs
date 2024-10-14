using Day38Concepts.StudentTestData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day38Concepts.QuantifierOperations
{
    public class AllMethod
    {
        /// <summary>
        /// it checks all the elements in the data source with given condition
        /// and returns bool value.
        /// </summary>
        public void AllMethodExample()
        {
            StudentData studentData = new StudentData();
            List<Student> students = studentData.GetStudents();

            var methodSyntax = students.All(student => student.Marks > 70);

            var querySyntax = (from student in students
                               select student).All(student => student.Marks > 70);

            Console.WriteLine($" Is All students having marks more than 70:: {querySyntax}");
        }

        public void AllMethodExampleWithWhere()
        {
            StudentData studentData = new StudentData();
            List<Student> students = studentData.GetStudents();

            var methodSyntax = students.Where(student => student.Subject.All(marks => marks.SubjectMarks > 70))
                                .Select(student => student).ToList();

            var querySyntax = (from student in students
                               where student.Subject.All(marks => marks.SubjectMarks > 70)
                               select student).ToList();

            foreach(var student in querySyntax)
            {
                Console.WriteLine($"Name:{student.Name}");
            }
        }

        public void AllMethodForIntegerList()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            bool allPositive = numbers.All(n => n > 0);
            Console.WriteLine($"All numbers are positive: {allPositive}");

            bool allLessThanFive = numbers.All(n => n < 5);
            Console.WriteLine($"All numbers are less than 5: {allLessThanFive}");
        }
    }

    public class AnyMethod
    {
        /// <summary>
        /// retruns true if any one of the element in the 
        /// data source satisfies the condition
        /// </summary>
        public void AnyMethodExample()
        {
            StudentData studentData = new StudentData();
            List<Student> students = studentData.GetStudents();

            var methodSyntax = students.Any(student => student.Marks > 90);

            var querySyntax = (from student in students
                               select student).Any(student => student.Marks > 90);

            Console.WriteLine($"Is any Oone of the Student having Morethan 90 Marks {methodSyntax}");
        }

        public void AnyMethodExampleWithWhere()
        {
            StudentData studentData = new StudentData();
            List<Student> students = studentData.GetStudents();

            var methodSyntax = students.Where(student => student.Subject.Any(marks => marks.SubjectMarks > 90))
                                .Select(student => student).ToList();

            var querySyntax = (from student in students
                               where student.Subject.Any(marks => marks.SubjectMarks > 85)
                               select student).ToList();

            foreach (var student in querySyntax)
            {
                Console.WriteLine(student.Name);
            }
        }
    }

    public class ContainsMethod
    {
        /// <summary>
        /// returns true when the given value in the condition present 
        /// in the datasource
        /// </summary>
        public void ContainsMethodExample()
        {
            List<string> studentNames = new List<string>() { "john", "kim", "tom", "sam" };

            var isExistsMethodSyntax = studentNames.AsEnumerable().Contains("kim");

            var isExistsUsingQuerySyntax = (from name in studentNames
                                            select name).Contains("sam");

            Console.WriteLine($"Is sam is Present:{isExistsUsingQuerySyntax}");
        }

        /// <summary>
        /// by default Contain method check the refernces inorder to check the values
        /// we use Iequality Comparer
        /// </summary>
        public void ConatinsMethodForComplexType()
        {
            List<Student> students = new List<Student>()
          {
              new Student() {Id=1,Name="John"},
              new Student() {Id=2,Name="Kim"}
          };

            var comparer = new StudentComparer();

            var isExistsMethodSyntax = students.Contains(new Student() { Id = 1, Name = "John" }, comparer);

            var isExistsQuerySyntax = (from student in students
                                       select student).Contains(new Student() { Id = 1, Name = "John" }, comparer);

            Console.WriteLine(isExistsMethodSyntax);
        }
    }

    public class CombinedExamples
    {
        public void CombinedExamplesForDateAndTime()
        {
            List<DateTime> dates = new List<DateTime>
        {
            new DateTime(2023, 1, 1),
            new DateTime(2024, 6, 10),
            new DateTime(2022, 12, 25),
            new DateTime(2024, 10, 4)
        };

            // All: Check if all dates are in the future
            bool allDatesInFuture = dates.All(date => date > DateTime.Now);
            Console.WriteLine($"All dates are in the future: {allDatesInFuture}");

            // Any: Check if any date is in the past
            bool anyDateInPast = dates.Any(date => date < DateTime.Now);
            Console.WriteLine($"Any date is in the past: {anyDateInPast}");

            // Contains: Check if the list contains a specific date
            DateTime targetDate = new DateTime(2024, 6, 10);
            bool containsDate = dates.Contains(targetDate);
            Console.WriteLine($"List contains {targetDate.ToShortDateString()}: {containsDate}");
        }

        public void CombinedExamplesForDouble()
        {
            List<double> prices = new List<double> { 19.99, 49.99, 100.00, 150.50 };

            // All: Check if all prices are greater than $10
            bool allPricesGreaterThan10 = prices.All(p => p > 10.00);
            Console.WriteLine($"All prices are greater than $10: {allPricesGreaterThan10}");

            // Any: Check if any price is greater than $100
            bool anyPriceGreaterThan100 = prices.Any(p => p > 100.00);
            Console.WriteLine($"Any price greater than $100: {anyPriceGreaterThan100}");

            // Contains: Check if the list contains the price $49.99
            bool containsPrice = prices.Contains(49.99);
            Console.WriteLine($"List contains $49.99: {containsPrice}");
        }

        public void CombinedExamplesForString()
        {
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David" };

            // All: Check if all names have more than 3 characters
            bool allNamesLongerThanThree = names.All(name => name.Length > 3);
            Console.WriteLine($"All names are longer than 3 characters: {allNamesLongerThanThree}");

            // Any: Check if any name starts with 'A'
            bool anyStartsWithA = names.Any(name => name.StartsWith("A"));
            Console.WriteLine($"Any name starts with 'A': {anyStartsWithA}");

            // Contains: Check if the list contains "Charlie"
            bool containsCharlie = names.Contains("Charlie");
            Console.WriteLine($"List contains 'Charlie': {containsCharlie}");
        }
    }
}
