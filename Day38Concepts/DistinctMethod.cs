using System;
using System.Collections.Generic;
using System.Linq;

namespace Day38Concepts.SetOperations
{
    public class DistinctMethod
    {
        /// <summary>
        /// Distinict method removes the duplicates presnet in the datasource
        /// </summary>
        public void DistnictMethodOnSimpleList()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 1, 12, 3, 33, 4, 4, 1, 13, 3, 4, 4, 41, 2 };

            var methodSyntax = numbers.Distinct();

            var querySyntax = (from number in numbers
                               select number).Distinct().ToList();

            foreach (int number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Iequatable will comapare the class to itself
        /// </summary>
        public void DistinctForIEquitableClass()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "john" },
                new Employee() { Id = 2, Name = "Mark" },
                new Employee() { Id = 1, Name = "john" },
                new Employee() { Id = 4, Name = "Sam" }
            };

            var methodSyntax = employees.Distinct().ToList();

            foreach (var employee in methodSyntax)
            {
                Console.WriteLine(employee.Name);
            }
        }

        /// <summary>
        /// Iequality comparer works with two objects and it compare two object values
        /// </summary>
        public void DistinctForIEqualityClass()
        {
            List<Student> students = new List<Student>()
          {
              new Student() {Id=1,Name="John"},
              new Student() {Id=2,Name="Kim"},
              new Student(){Id=1,Name="John"}
          };
            var comparer = new StudentComparer();

            var methodSyntax = students.Distinct(comparer).ToList();

            foreach (var employee in methodSyntax)
            {
                Console.WriteLine(employee.Id);
            }
        }
    }

    public class Employee : IEquatable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Equals(Employee other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            return Id.Equals(other.Id) && Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            int idHashCode = Id.GetHashCode();
            int nameHashCode = Name.GetHashCode();

            return idHashCode ^ nameHashCode;
        }
    }
}
