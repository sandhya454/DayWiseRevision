using System;
using employee= Day31Concepts.EmployeeManagement;
using Day31Concepts.StudentManagement;
using Day31Concepts.StudentManagement.StaffManagement;
using Day31Concepts.ClassIntroduction;
using Day31Concepts.StaticAndInstanceMembers;
using acessModifiers = Day31Concepts.PrivatePublicAndProtected;
using Day31Concepts.InternalAndProtectedInternal;
using Day31Concepts.PartialClass;

namespace Day31Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EmployeeInfo();
            //StudentInfo();
            //ConstructorExample();
            //StaticAndInstanceMemberExamples();
            //AccessModifiersExamples();
            //InternalProtectedInternalExample();
            PartialClassExample();
        }

        public static void EmployeeInfo()
        {
            employee.Department department = new employee.Department();
            department.DisplayDepartmentInfo();

            employee.Payrole payrole = new employee.Payrole();
            payrole.DisplayDepartmentInfo();
        }

        public static void StudentInfo()
        {
            Department department = new Department();
            department.DisplayDepartmentInfo();

            PermanantStaff permanantStaff = new PermanantStaff();
            permanantStaff.DisplayStaffInfo();
        }

        public static void ConstructorExample()
        {
            Customer customer = new Customer();
            customer.PrintFullName();

            Customer customer2 = new Customer("Savar","Technologies");
            customer2.PrintFullName();
        }

        public static void StaticAndInstanceMemberExamples()
        {
            //Circle circle1 = new Circle(5);
            //float areaOfCirce1 = circle1.CalculateArea();
            //Console.WriteLine($"Area of Circle {areaOfCirce1}");

            //Circle circle2 = new Circle(6);
            //float areaOfCirce2 = circle2.CalculateArea();
            //Console.WriteLine($"Area of Circle {areaOfCirce2}");

            Car car1 = new Car("Toyota", "Red");
            car1.DisplayCarDetails();

            Car car2 = new Car("Honda", "Blue");
            car2.DisplayCarDetails();

            Console.WriteLine($"Total Cars Created: {Car.GetTotalCars()}");
        }

        public static void AccessModifiersExamples()
        {
            acessModifiers.CorporateCustomer corporateCustomer= new acessModifiers.CorporateCustomer();
            corporateCustomer.PrintName();
        }

        public static void InternalProtectedInternalExample()
        {
            Employee employee = new Employee();
            employee.PritnId();

            EmployeeName employeeName = new EmployeeName();
            employeeName.PrintName();
        }

        public static void PartialClassExample()
        {
            HelloWorld hello = new HelloWorld();
            hello.HelloWordl();
            hello.HelloUniverse();

            Person person = new Person("John", "Doe");
            person.DisplayFullName();
            person.DisplayLastName();
        }
    }
}
