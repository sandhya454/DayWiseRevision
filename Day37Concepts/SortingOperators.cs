using Day37Concepts.EmployeeData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day37Concepts.SortingOperators
{
    public class OrderByMethod
    {
        /// <summary>
        /// it will return the values in order(asceding order)
        /// </summary>
        public void IntegerExample()
        {
            var dataSource = new List<int>() { 10, 90, 100, 20, 45, 1, 2, 7, 18, 29, 87, 29 };

            var querySyntax = (from number in dataSource
                               where number > 50
                               orderby number
                               select number).ToList();

            var methodSyntax = dataSource.Where(number => number > 40).OrderBy(number => number).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void StringExample()
        {
            var dataSource = new List<string>() { "Dimple", "Andrea", "Monica", "Gunther", "Chandler", "RossGeller", "Tom", "John" };

            var querySyntax = (from name in dataSource
                               where name.Length >= 7
                               orderby name
                               select name).ToList();

            var methodSyntax = dataSource.Where(name => name.Length <= 4).OrderBy(name => name).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine($"{name}");
            }
        }

        public void ObjectExample()
        {
            EmployeeTestData employeeData = new EmployeeTestData();
            List<Employee> employees = employeeData.GetEmployee();

            var querySyntax = (from employee in employees
                               where employee.Name.Length >= 4
                               orderby employee.Name
                               select employee).ToList();

            var methodSyntax = employees.Where(employee => employee.Name.Length > 4).OrderBy(employee => employee.Name).ToList();

            foreach (var employee in querySyntax)
            {
                Console.WriteLine($"id:{employee.Id} Name:{employee.Name}");
            }
        }
    }

    public class OrderByDescending
    {
        /// <summary>
        /// It will return the values in desecnding order
        /// </summary>
        public void IntegerExample()
        {
            var dataSource = new List<int>() { 10, 90, 100, 20, 45, 1, 2, 7, 18, 29, 87, 29 };

            var querySyntax = (from number in dataSource
                               where number > 20
                               orderby number descending
                               select number).ToList();

            var methodSyntax = dataSource.Where(number => number < 20).OrderByDescending(number => number).ToList();

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void StringExample()
        {
            var dataSource = new List<string>() { "Dimple", "Andrea", "Monica", "Gunther", "Chandler", "RachelGreen", "RossGeller", "Tom", "John" };

            var querySyntax = (from name in dataSource
                               where name.Length >= 6
                               orderby name descending
                               select name).ToList();

            var methodSyntax = dataSource.Where(name => name.Length >= 4).OrderByDescending(name => name).ToList();

            foreach (var name in querySyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void ClassExample()
        {
            EmployeeTestData employeeData = new EmployeeTestData();
            List<Employee> employees = employeeData.GetEmployee();

            var querySyntax = (from employee in employees
                               where employee.Id >= 3
                               orderby employee.Id descending
                               select employee).ToList();

            var methodSyntax = employees.Where(employee => employee.Name.Length >= 4)
                                .OrderByDescending(employee => employee.Name).ToList();

            foreach (var employee in querySyntax)
            {
                Console.WriteLine($"Id:{employee.Id} Name:{employee.Name}");
            }
        }
    }

    public class ReverseMethod
    {
        public void IntegerExample()
        {
            int[] rollNumbers = new int[] { 1, 2, 10, 3, 5, 9, 12, 23 };

            var methodSyntax = rollNumbers.Reverse();

            var querySyntax = (from number in rollNumbers
                               select number).Reverse();

            foreach (int number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void StringExample()
        {
            List<string> names = new List<string>() { "Bob", "Tom", "Kim", "John", "Mark" };

            //names.Reverse();
            //foreach (string name in names)
            //{
            //    Console.WriteLine($"{name}");
            //}

            var methodSyntax = names.AsEnumerable().Reverse();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void ClassExample()
        {
            EmployeeTestData employeeData = new EmployeeTestData();
            List<Employee> employees = employeeData.GetEmployee();

            var reversedEmployees = employees.AsEnumerable().Reverse();
            foreach (var employee in reversedEmployees)
            {
                Console.WriteLine($"Id:{employee.Id}, Name: {employee.Name}");
            }
        }
    }
}
