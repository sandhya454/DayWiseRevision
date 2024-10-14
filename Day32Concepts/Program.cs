using System;
using inheritance=Day32Concepts.Inheritance;
using Day32Concepts.MethodHiding;
using Day32Concepts.Polymorphism;
using Day32Concepts.MethodOverridingAndHiding;
using Day32Concepts.NeedForProperties;
using Day32Concepts.Properties;
using structures=Day32Concepts.Structures;

namespace Day32Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InheritanceExample();
            //MethodHidingExample();
            //PolymorphismExample();
            //MethodHidingAndOverrideExample();
            //MethodOverloadingExample();
            //GetterSetterExample();
            //PorpertiesExample();
            StructuresExample();
        }

        public static void InheritanceExample()
        {
            inheritance.FullTimeEmployee fullTimeEmployee = new inheritance.FullTimeEmployee();
            fullTimeEmployee.firstName = "Ross";
            fullTimeEmployee.lastName = "Geller";
            fullTimeEmployee.yearlySalary = 50000;
            fullTimeEmployee.PrintName();

            inheritance.PartTimeEmployee partTimeEmployee = new inheritance.PartTimeEmployee();
            partTimeEmployee.firstName = "Chandler";
            partTimeEmployee.lastName = "Bing";
            partTimeEmployee.hourlySalary = 30000;
            partTimeEmployee.PrintName();

            inheritance.ChildClass childClass = new inheritance.ChildClass();
        }

        public static void MethodHidingExample()
        {
            RegularCustomer regularCustomer = new RegularCustomer();
            regularCustomer.firstName = "Shaun";
            regularCustomer.lastName = "Murphy";
            regularCustomer.PrintName();
        }

        public static void PolymorphismExample()
        {
            Department[] students = new Department[4];
            students[0] = new Department();
            students[1] = new Electrical();
            students[2] = new Computers();
            students[3] = new Mechanical();

            foreach (Department student in students)
            {
                student.PrintName();
            }

            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle();
            shapes[1] = new Rectangle();
            shapes[2] = new Triangle();

            Console.WriteLine("\nDrawing all shapes using polymorphism in an array:");
            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }

            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach(Employee employee in employees)
            {
                employee.PrintFullName();
            }
        }

        public static void MethodHidingAndOverrideExample()
        {
            BaseClass baseClass = new DerivedClass();
            baseClass.Print();
            baseClass.PrintName();
        }

        public static void MethodOverloadingExample()
        {
            MethodOverloading methodOverloading = new MethodOverloading();
            methodOverloading.Add(2, 3);
            methodOverloading.Add(3, 4, 5);
            methodOverloading.Add(4.5, 5.3);
            methodOverloading.Add("savar", "Technologies");
            methodOverloading.Display(3, "Hello");
            methodOverloading.Display("Hiii", 5);
        }

        public static void GetterSetterExample()
        {
            Person person = new Person();
            person.SetId(100);
            person.SetName("Mani");

            Console.WriteLine($"Name:{person.GetName()} id :{person.GetId()}");
        }

        public static void PorpertiesExample()
        {
            Student student = new Student();
            student.Id = 1;
            student.Name = "Manikanta";
            Console.WriteLine($"Name:{student.Name} id :{student.Id}");
        }

        public static void StructuresExample()
        {
            structures.Customer customer = new structures.Customer(10,"Mark");
            customer.PrintDetails();

            structures.Customer customer1 = new structures.Customer();
            customer1.Id = 1;
            customer1.Name = "john";
            customer1.PrintDetails();

            structures.Customer customer2 = new structures.Customer()
            {
                Id = 2,
                Name = "mani"
            };
            customer2.PrintDetails();
        }
    }
}
