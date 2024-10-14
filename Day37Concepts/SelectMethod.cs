using Day37Concepts.EmployeeData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day37Concepts.ProjectionMethods
{
    public class SelectMethod
    {
        public void BasicExample()
        {
            EmployeeTestData employeeData = new EmployeeTestData();
            List<Employee> employees = employeeData.GetEmployee();

            var querySyntax = (from employee in employees
                               select employee).ToList();

            var methodSyntax = employees.ToList();

            foreach (var employee in querySyntax)
            {
                Console.WriteLine($"Id:{employee.Id} Name:{employee.Name} Email:{employee.Email}");
            }
        }

        /// <summary>
        /// if you want to select only one property in an object
        /// </summary>
        public void SelectOneProperty()
        {
            EmployeeTestData employeeData = new EmployeeTestData();
            List<Employee> employees = employeeData.GetEmployee();

            var querySyntax = (from employee in employees
                               select employee.Id.ToString()).ToList();

            var methodSyntax = employees.Select(employee => employee.Id).ToList();

            foreach (var id in querySyntax)
            {
                Console.WriteLine($"Id:{id}");
            }
        }

        /// <summary>
        /// if you want select more than one property 
        /// </summary>
        public void SelectManyProperties()
        {
            EmployeeTestData employeeData = new EmployeeTestData();
            List<Employee> employees = employeeData.GetEmployee();

            var querySyntax = (from employee in employees
                               select new Employee()
                               {
                                   Id = employee.Id,
                                   Email = employee.Email
                               }).ToList();

            var methodSyntax = employees.Select(employee => new Employee()
            {
                Id = employee.Id,
                Name = employee.Name,
            }).ToList();

            foreach (var employee in methodSyntax)
            {
                Console.WriteLine($"Name:{employee.Name}");
            }
        }

        /// <summary>
        /// if we want to assign the data into another class
        /// </summary>
        public void AssignDataToOtherClass()
        {
            EmployeeTestData employeeData = new EmployeeTestData();
            List<Employee> employees = employeeData.GetEmployee();

            var setDataToStudentQuerySyntax = (from employee in employees
                                               select new Student()
                                               {
                                                   StudentId = employee.Id,
                                                   StudentName = employee.Name,
                                                   StudentEmail = employee.Email
                                               }).ToList();

            var setDataToStudentMethodSyntax = employees.Select(employee => new Student()
            {
                StudentName = employee.Name,
                StudentEmail = employee.Email,
                StudentId = employee.Id
            }).ToList();

            foreach (var student in setDataToStudentMethodSyntax)
            {
                Console.WriteLine($"Id:{student.StudentId} Name:{student.StudentName} Email:{student.StudentEmail}");
            }
        }

        /// <summary>
        /// if we want to assign the data to ananymous class
        /// </summary>
        public void AssignDataToAnanymousType()
        {
            EmployeeTestData employeeData = new EmployeeTestData();
            List<Employee> employees = employeeData.GetEmployee();

            var querySyntax = (from employee in employees
                               select new
                               {
                                   CustomId = employee.Id,
                                   CustomName = employee.Name,
                                   CustomEmail = employee.Email
                               }).ToList();

            var methodSyntax = employees.Select(employee => new
            {
                CustomId = employee.Id,
                CustomName = employee.Name,
                CustomEmail = employee.Email
            }).ToList();

            foreach (var customer in querySyntax)
            {
                Console.WriteLine($"id:{customer.CustomId} Name:{customer.CustomName}");
            }
        }

        public void SelectDataByUsingIndex()
        {

            EmployeeTestData employeeData = new EmployeeTestData();
            List<Employee> employees = employeeData.GetEmployee();

            var queryToSelectIndex = employees.Select((employee, index) => new { Index = index, Name = employee.Name }).ToList();

            foreach (var employee in queryToSelectIndex)
            {
                Console.WriteLine($"Index:{employee.Index} Name:{employee.Name}");
            }
        }
    }
}
