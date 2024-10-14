using System;
using System.Collections.Generic;
using System.Linq;

namespace Day38Concepts.PartitioningOperators
{
    public class TakeMethod
    {
        /// <summary>
        /// Take method is used to get first n number of records 
        /// from a data source.it will not change the element position.
        /// </summary>
        public void TakeMethodExample()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Take(5).ToArray();

            var mixedSyntax = (from number in numbers
                               select number).Take(4).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void TakeMethodWithFilterExample()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Where(number => number > 3).Take(5).ToList();
            //var methodSyntax = numbers.Take(5).Where(number => number > 3).ToArray();

            var mixedSyntax = (from number in numbers
                               where number > 3
                               select number).Take(5).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }
    }

    public class TakeWhileMethod
    {
        /// <summary>
        /// Takewhile method returns the elements uuntil the condition
        /// satisfies ,if condition fails it wont check remaning elements.
        /// </summary>
        public void TakeWhileMethodForIntList()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var methodSyntax = numbers.TakeWhile(number => number < 7).ToList();

            var mixedSyntax = (from number in numbers
                               select number).TakeWhile(number => number < 7).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void TakeWhileMethodForString()
        {
            List<string> names = new List<string>() { "Kim", "Mark", "bob", "Jo", "Monica" };

            var methodSyntaxForNames = names.TakeWhile((name, index) => name.Length > index).ToList();
            var querySyntax = (from name in names
                               select name).TakeWhile((name, index) => name.Length > index).ToList();

            foreach (var name in methodSyntaxForNames)
            {
                Console.WriteLine(name);
            }
        }
    }

    public class SkipMethod
    {
        /// <summary>
        /// Skipmethod skips the first n number of elements  in data source 
        /// and returns remainig elements without chaning the position of elements.
        /// </summary>
        public void SkipMethodExample()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Where(number => number > 4).Skip(3).ToList();

            var mixedSyntax = (from number in numbers
                               select number).Skip(3).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }
    }

    public class SkipWhileMethod
    {
        /// <summary>
        /// SkipWhile method skips the elements until the condition is satisfied,
        /// and return the remaning elements. Once the condition fails it wont check 
        /// the remaming elements
        /// </summary>
        public void SkipWhileForIntegers()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 5 };

            var methodSyntax = numbers.SkipWhile(number => number < 6).ToList();

            var mixedSyntax = (from number in numbers
                               select number).SkipWhile(number => number < 6).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void SkipWhileForStrings()
        {
            List<string> names = new List<string>() { "jon", "bob", "Tom", "M", "Mark", "Marry" };

            var methodSyntax = names.SkipWhile((name, index) => name.Length > index).ToList();

            var mixedSyntax = (from name in names
                               select name).SkipWhile((name, index) => name.Length > index).ToList();

            foreach (var name in mixedSyntax)
            {
                Console.WriteLine(name);
            }
        }
    }

    public class ComplexExample
    {
        public void PartioningOperatorsForComplexExample()
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeId = 1, Name = "Alice", Age = 25, Department = "IT", Salary = 50000 },
            new Employee { EmployeeId = 2, Name = "Bob", Age = 30, Department = "Finance", Salary = 60000 },
            new Employee { EmployeeId = 3, Name = "Charlie", Age = 35, Department = "IT", Salary = 70000 },
            new Employee { EmployeeId = 4, Name = "David", Age = 28, Department = "IT", Salary = 65000 },
            new Employee { EmployeeId = 5, Name = "Eva", Age = 40, Department = "HR", Salary = 80000 },
            new Employee { EmployeeId = 6, Name = "Frank", Age = 33, Department = "IT", Salary = 68000 },
            new Employee { EmployeeId = 7, Name = "Grace", Age = 27, Department = "Finance", Salary = 55000 },
            new Employee { EmployeeId = 8, Name = "Hannah", Age = 29, Department = "HR", Salary = 47000 }
        };

            // 1. Take: Take the first 3 employees
            var firstThreeEmployees = employees.Take(3);
            Console.WriteLine("First 3 employees:");
            foreach (var employee in firstThreeEmployees)
            {
                Console.WriteLine($"{employee.Name}, Age: {employee.Age}, Department: {employee.Department}, Salary: {employee.Salary}");
            }
            Console.WriteLine();

            // 2. Skip: Skip the first 3 employees, take the rest
            var remainingEmployees = employees.Skip(3);
            Console.WriteLine("Employees after skipping the first 3:");
            foreach (var employee in remainingEmployees)
            {
                Console.WriteLine($"{employee.Name}, Age: {employee.Age}, Department: {employee.Department}, Salary: {employee.Salary}");
            }
            Console.WriteLine();

            // 3. TakeWhile: Take employees while their salary is below 70,000
            var lowSalaryEmployees = employees.TakeWhile(employee => employee.Salary < 70000);
            Console.WriteLine("Employees with salary below 70,000:");
            foreach (var employee in lowSalaryEmployees)
            {
                Console.WriteLine($"{employee.Name}, Age: {employee.Age}, Department: {employee.Department}, Salary: {employee.Salary}");
            }
            Console.WriteLine();

            // 4. SkipWhile: Skip employees while their age is less than 30, take the rest
            var seniorEmployees = employees.SkipWhile(employee => employee.Age < 30);
            Console.WriteLine("Employees after skipping those younger than 30:");
            foreach (var employee in seniorEmployees)
            {
                Console.WriteLine($"{employee.Name}, Age: {employee.Age}, Department: {employee.Department}, Salary: {employee.Salary}");
            }
            Console.WriteLine();

            // 5. Combining Skip and Take: Skip the first 2 employees, then take the next 3
            var middleEmployees = employees.Skip(2).Take(3);
            Console.WriteLine("Middle 3 employees (after skipping 2):");
            foreach (var employee in middleEmployees)
            {
                Console.WriteLine($"{employee.Name}, Age: {employee.Age}, Department: {employee.Department}, Salary: {employee.Salary}");
            }
            Console.WriteLine();

            // 6. Complex TakeWhile with a condition on both Age and Department
            var youngITEmployees = employees.TakeWhile(employee => employee.Age < 35 && employee.Department == "IT");
            Console.WriteLine("Young IT employees (Age < 35):");
            foreach (var employee in youngITEmployees)
            {
                Console.WriteLine($"{employee.Name}, Age: {employee.Age}, Department: {employee.Department}, Salary: {employee.Salary}");
            }
        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }
}
