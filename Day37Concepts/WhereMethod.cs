using Day37Concepts.EmployeeData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day37Concepts.FilteringOperators
{
    public class WhereMethod
    {
        public void IntegerExample()
        {
            var dataSource = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 92, 3, 4, 6 };

            var querySyntax = (from number in dataSource
                               where number > 5
                               select number).ToList();

            var methodSyntax = dataSource.Where(number => number > 9).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void IntegerExampleWithMultipleConditions()
        {
            var dataSource = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 92, 3, 4, 6 };

            var querySyntax = (from number in dataSource
                               where number > 5 || number<=10
                               select number).ToList();

            var methodSyntax = dataSource.Where(number => number > 4 && number <10).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void StringExample()
        {
            var names = new List<string> { "Diana", "shaun", "carle", "Jarde", "Joe" };

            var querySyntax = (from name in names
                               where  name.Length == 5
                               select name).ToList();

            var methodSyntax = names.Where(name => name.Length == 3).ToList();

            foreach (var name in querySyntax)
            {
                Console.WriteLine($"{name}");
            }
        }

        public void StringExampleWithMultipleConditions()
        {
            var names = new List<string> { "Mark", "Marry", "John", "MonicaGeller", "Chandler" };

            var querySyntax = (from name in names
                               where name.Length > 5 && name.Length <= 7
                               select name).ToList();

            var methodSyntax = names.Where(name => name=="Mark"|| name.Length >7).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine($"{name}");
            }
        }

        public void ClassExample()
        {
            EmployeeTestData employeeData = new EmployeeTestData();
            List<Employee> employees = employeeData.GetEmployee();

            var querySyntax = (from employee in employees
                               where employee.Languages.Count == 0
                               select employee).ToList();

            var methodSyntax = employees.Where(employee => employee.Id >= 2 && employee.Name.Length == 6).ToList();

            foreach (var employee in querySyntax)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }

    public class OfTypeMethod
    {
        /// <summary>
        /// it will return the values based on datatype which we mention
        /// </summary>
        public void OfTypeMethodExample()
        {
            var dataSource = new List<object> { "Kim", "john", "Peter", "Rachel", "Gunther", 1, 2, 34, 4, 5, 5, 6 };

            var methodSyntax = dataSource.OfType<string>().ToList();

            var querySyntax = (from number in dataSource
                               where number is int 
                               select number).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
        }

        public void OfTypeWithCondition()
        {
            var dataSource = new List<object> { "Kim", "john", "Peter", "Rachel", "Gunther", 1, 2, 34, 4, 5, 5, 6 };

            var methodSyntax = dataSource.OfType<string>().Where(name=>name.Length==4).ToList();

            var querySyntax = (from number in dataSource
                               where number is int item && item > 4
                               select number).ToList();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
        }

        public void OfTypeExampleForClass()
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog(),
                new Cat(),
                new Dog(),
                new Animal()
            };

            // Use OfType<Dog>() to filter only Dog objects
            var methodSyntax = animals.OfType<Dog>().ToList();

            var querySyntax = from animal in animals
                       where animal is Dog
                       select animal;

            Console.WriteLine($"Number of dogs: {methodSyntax.Count}");

        }

        public void OfTypeExampleForClassWithCondition()
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog { Age = 3 },
                new Cat(),
                new Dog { Age = 5 },
                new Animal(),
                new Dog { Age = 1 }
            };

            // Query syntax to filter Dog objects older than 2 years
            var olderDogs = from animal in animals
                            where animal is Dog dog && dog.Age > 2
                            select animal;

            var methodSyntax = animals.OfType<Dog>().Where(dog => dog.Age > 2).ToList();

            Console.WriteLine($"Number of dogs older than 2 years: {olderDogs.Count()}");
        }
    }

    public class Animal { }
    public class Dog : Animal { public int Age { get; set; } }
    public class Cat : Animal { }
}
