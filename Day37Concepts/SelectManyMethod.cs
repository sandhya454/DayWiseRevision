using Day37Concepts.EmployeeData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day37Concepts.ProjectionMethods
{
    public class SelectManyMethod
    {
        public void SlectManyMethodForLists()
        {
            List<string> nameLists = new List<string>() { "Carlie", "Brownie" };

            var methodSyntaxResult = nameLists.SelectMany(character => character).ToList();
            var querySyntaxResult = (from names in nameLists
                                     from characters in names
                                     select characters).ToList();

            foreach (var character in querySyntaxResult)
            {
                Console.WriteLine(character);
            }
        }

        public void SelectManyMethodForClasses()
        {
            EmployeeTestData employeeData = new EmployeeTestData();
            List<Employee> employees = employeeData.GetEmployee();

            var methodSyntax = employees.SelectMany(employee => employee.Programming).ToList();
            var querySyntax = (from employee in employees
                               from programming in employee.Programming
                               select programming).ToList();

            foreach (var programing in querySyntax)
            {
                Console.WriteLine(programing);
            }
        }

        public void SelectManyMethodExample()
        {
            EmployeeTestData employeeData = new EmployeeTestData();
            List<Employee> employees = employeeData.GetEmployee();

            var methodSyntax = employees.SelectMany(employee => employee.Languages).ToList();
            var querySyntax = (from employee in employees
                               from language in employee.Languages
                               select language).ToList();

            if (querySyntax.Count == 0)
            {
                Console.WriteLine("No languages found for any employee.");
            }
            else
            {
                Console.WriteLine("Languages of Employees:");
                foreach (var skills in querySyntax)
                {
                    Console.WriteLine(skills.Technology);
                }
            }
        }
    }
}
