using Day38Concepts.StudentTestData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day38Concepts.ElementOperations
{
    public class FirstVsFirstOrDefault
    {
        /// <summary>
        /// First and FirstOrDefault returns the first value of the datasource,
        /// if the value is not present the  First method throws exception
        /// where firstOrDEfault method returns Default value of the type
        /// </summary>
        public void FirstMethodExample()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 5, 6, 7, 8, 9 };

            var methodSyntax = numbers.First();
            Console.WriteLine("By using First Method::" + methodSyntax);

            methodSyntax = numbers.Where(number => number > 5).First();
            Console.WriteLine("After Applying filter::" + methodSyntax);

            //Another way of  writing the condition
            Console.WriteLine("Another way:");
            methodSyntax = numbers.First(number => number > 5);
            Console.WriteLine(methodSyntax);

            var mixedSyntax = (from number in numbers
                               select number).First();
        }

        public void FirstOrDefaultMethod()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 5, 6, 7, 8, 9 };

            var methodSyntax = numbers.FirstOrDefault(number => number > 10);
            Console.WriteLine($"First or default {methodSyntax}:");
        }

        public void ComplexExampleForFirstMethod()
        {
            var users = new List<User>()
            {
                new User(){Id=1,UserName="Admin",Password="Admin"},
                new User(){Id=2,UserName="User1",Password="User1"},
                new User(){Id=1,UserName="User2",Password="User2"},
                new User(){Id=1,UserName="User3",Password="User3"}
            };

            var methodSyntax = users.FirstOrDefault(user => user.UserName == "Admin" && user.Password == "Admin");

            var mixedSyntax = (from user in users
                               select user).FirstOrDefault(user => user.UserName == "Admin" && user.Password == "Admin");

            Console.WriteLine(methodSyntax.UserName);
        }
    }

    public class LastVsLastOrDefault
    {
        /// <summary>
        /// Last or LastOrDefault method returns the last eleemnt in the dataSource
        /// based on the conditons if element is not present the last method throws
        /// exception, where LastOrDefault method returns defalut value of the type
        /// </summary>
        public void LasttMethod()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 9 };

            var methodSyntax = numbers.Last();

            //throws an exception
            //var methodSyntax2 = numbers.Last(number => number > 10);

            var mixedSyntax = (from number in numbers
                               select number).Last();
            Console.WriteLine(mixedSyntax);
        }

        public void LastOrDefaultMethod()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 9 };

            //return default value
            var methodSyntax = numbers.LastOrDefault(number => number > 10);

            var mixedSyntax = (from number in numbers
                               select number).LastOrDefault(number => number > 10);

            Console.WriteLine(mixedSyntax);
        }

        public void ComplexExample()
        {
            StudentData studentData = new StudentData();
            List<Student> students = studentData.GetStudents();

            var methodSyntax = students.LastOrDefault(student=>student.Marks>70);

            Console.WriteLine(methodSyntax.Name);
        }
    }

    public class SingleVsSingleOrDefault
    {
        /// <summary>
        /// Single and SingleOrDefault method returns single value from the data source
        /// if element present in multiple places both methods throw exception,
        /// and if element is not present in data source Single method throws exception
        /// and SingleOrDefault method returns default value
        /// </summary>
        public void ExampleForEmptyList()
        {
            List<int> numbers = new List<int>() { };

            //both methods throws exception because data source is empty
            var methodSyntax = numbers.Single();
            methodSyntax = numbers.SingleOrDefault();
        }

        public void ExampleForMoreValues()
        {
            List<int> numbers = new List<int>() { 1, 2 };

            //both methods throw exception because data source contains more than one element
            var methodSyntax = numbers.Single();
            methodSyntax = numbers.SingleOrDefault();
        }

        public void SingleMethodWithCondition()
        {
            List<int> numbers = new List<int>() { 1, 2, 3 };

            var methodSyntax = numbers.Single(number => number < 2);

            var methodSyntax2 = numbers.SingleOrDefault(number => number > 4);

            Console.WriteLine(methodSyntax);
        }

        public void ComplexExample()
        {
            StudentData studentData = new StudentData();
            List<Student> students = studentData.GetStudents();

            var methodSyntax = students.SingleOrDefault(student => student.Marks > 90);
            Console.WriteLine(methodSyntax.Name);
        }
    }

    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
