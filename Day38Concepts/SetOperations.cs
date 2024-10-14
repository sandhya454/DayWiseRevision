using Day38Concepts.StudentTestData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day38Concepts.SetOperations
{
    public class ExceptMethod
    {
        /// <summary>
        /// except method return the values which is not present in another datasource
        /// </summary>
        public void ExceptMethodForLists()
        {
            List<string> dataSource1 = new List<string>() { "A", "B", "C", "D" };
            List<string> dataSource2 = new List<string>() { "C", "D", "E", "F" };

            var methodSyntax = dataSource1.Except(dataSource2).ToList();

            var querySyntax = (from characters in dataSource1
                               select characters).Except(dataSource2).ToList();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
        }

        public void ExceptMethodForOneProperty()
        {
            StudentData studentData = new StudentData();
            var (students, students1) = studentData.GetStudentsDetails();

            var methodSyntax = students.Select(student => student.Name).Except(students1.Select(student => student.Name)).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void ExceptMethodUsingAnanymous()
        {
            StudentData studentData = new StudentData();
            var (students, students1) = studentData.GetStudentsDetails();

            var methodSyntax = students.Select(student => new { student.Id, student.Name }).
                                Except(students1.Select(student => new { student.Id, student.Name }).ToList());

            foreach (var student in methodSyntax)
            {
                Console.WriteLine(student.Name);
            }
        }

        public void ExceptMethodUsingComaparer()
        {
            StudentData studentData = new StudentData();
            var (students, students1) = studentData.GetStudentsDetails();

            var comparer = new StudentComparer();

            var methodSyntax = students.Except(students1, comparer).ToList();

            var querySyntax = (from student in students
                               select student).Except(students1, comparer).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine(student.Name);
            }
        }
    }

    public class IntersectMethod
    {
        /// <summary>
        /// Intersect method returns value present in the both the datasources
        /// </summary>
        public void IntersectMethodForLists()
        {
            List<string> dataSource1 = new List<string>() { "A", "B", "C", "D" };
            List<string> dataSource2 = new List<string> { "C", "D", "E", "F" };

            var methodSyntax = dataSource1.Intersect(dataSource2).ToList();

            var querySyntax = (from alphabets in dataSource1
                               select alphabets).Intersect(dataSource2).ToList();

            foreach (var alphabet in querySyntax)
            {
                Console.WriteLine(alphabet);
            }
        }

        public void IntersectMethodUsingAnanymous()
        {
            StudentData studentData = new StudentData();
            var (students, students1) = studentData.GetStudentsDetails();

            var methodSyntax = students.Select(student => new { student.Id, student.Name })
                                .Intersect(students1.Select(student => new { student.Id, student.Name })).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine(student.Name);
            }
        }

        public void IntersectMethodUsingComparer()
        {
            StudentData studentData = new StudentData();
            var (students, students1) = studentData.GetStudentsDetails();
            var comparer = new StudentComparer();

            var methodSyntax = students.Intersect(students1, comparer).ToList();
            var querySyntax = (from student in students
                               select student).Intersect(students1, comparer).ToList();

            foreach (var student in querySyntax)
            {
                Console.WriteLine(student.Name);
            }
        }
    }

    public class UnionMethod
    {
        /// <summary>
        /// union method removes the duplicates from the both data sources
        /// </summary>
        public void UnionMethodForList()
        {
            List<string> dataSource1 = new List<string>() { "A", "A", "B", "C", "D" };
            List<string> dataSource2 = new List<string>() { "C", "D", "E", "F" };

            var methodSyntax = dataSource1.Union(dataSource2).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
        }

        public void UnionMethodUsingAnanymousWay()
        {
            StudentData studentData = new StudentData();
            var (students, students1) = studentData.GetStudentsDetails();

            var methodSyntax = students.Select(student => new { student.Id, student.Name })
                            .Union(students1.Select(student => new { student.Id, student.Name })).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine(student.Name);
            }
        }

        public void UnionMethodUsingComparer()
        {
            StudentData studentData = new StudentData();
            var (students, students1) = studentData.GetStudentsDetails();
            var comparer = new StudentComparer();

            var methodSyntax = students.Union(students1, comparer).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
