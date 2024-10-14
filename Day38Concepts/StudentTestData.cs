using System.Collections.Generic;

namespace Day38Concepts.StudentTestData
{
    public class StudentData
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
        {
            new Student(){Name="John",Marks=89,
            Subject=new List<Subject>()
            {
                new Subject(){SubjectName="Math",SubjectMarks=90},
                new Subject(){SubjectName="English",SubjectMarks=89},
                new Subject(){SubjectName="Art",SubjectMarks=93},
                new Subject(){SubjectName="History",SubjectMarks=85}
            } },
            new Student(){Name="Marry",Marks=75,
            Subject=new List<Subject>()
            {
                new Subject(){SubjectName="Math",SubjectMarks=85},
                new Subject(){SubjectName="English",SubjectMarks=79},
                new Subject(){SubjectName="Art",SubjectMarks=83},
                new Subject(){SubjectName="History",SubjectMarks=65}
            } },
            new Student(){Name="Tom",Marks=93,
            Subject=new List<Subject>()
            {
                new Subject(){SubjectName="Math",SubjectMarks=80},
                new Subject(){SubjectName="English",SubjectMarks=79},
                new Subject(){SubjectName="Art",SubjectMarks=90},
                new Subject(){SubjectName="History",SubjectMarks=85}
            } }
        };

            return students;
        }

        public (List<Student>, List<Student>) GetStudentsDetails()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 1, Name = "john" },
                new Student() { Id = 2, Name = "kim" },
                new Student() { Id = 3, Name = "john" },
                new Student() { Id = 4, Name = "Mark" },
                new Student() { Id = 6, Name = "Monica" }
            };

            List<Student> students1 = new List<Student>()
            {
                new Student() { Id = 1, Name = "john" },
                new Student() { Id = 2, Name = "kim" },
                new Student() { Id = 5, Name = "john" },
                new Student() { Id = 6, Name = "Mark" }
            };

            return (students, students1);
        }
    }
}
