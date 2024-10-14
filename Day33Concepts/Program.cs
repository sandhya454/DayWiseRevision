using System;
using Day33Concepts.Interfaces;
using explicitInterface = Day33Concepts.ExplicitInterfaceImplementation;
using Abstract = Day33Concepts.AbstractClass;
using Daimond = Day33Concepts.DaimondProblem;
using Day33Concepts.MultipleInheritance;
using Day33Concepts.OptionalParameters;
using OverrideString=Day33Concepts.OverrideToString;
using Day33Concepts.ConstantAndReadOnly;


namespace Day33Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesExample();
            //ExplicitInterfaceExample();
            //AbstractClassExample();
            //DaimondProblemExample();
            //MultipleInheritanceExample();
            //ParameterArrayExample();
            //MethodOverloadingExample();
            //ParameterDefaultExample();
            //OptionalAttributeExample();
            //OverrideStringExample();
            //StringsExample();
            VaribalesExample();

        }

        public static void InterfacesExample()
        {
            Customer customer = new Customer();
            customer.Print();
            customer.Print2();

            Employee employee = new Employee();
            employee.Print1();
            employee.Print2();

            MultiFunctionDevice functionDevice = new MultiFunctionDevice();
            functionDevice.Print();
            functionDevice.Scan();

            SmartDevice smartDevice = new SmartDevice();
            smartDevice.MakeCall();
            smartDevice.BrowseWeb();
        }

        public static void ExplicitInterfaceExample()
        {
            explicitInterface.Customer customer = new explicitInterface.Customer();
            ((explicitInterface.IRegularCustomer)customer).InterfaceMethod();
            ((explicitInterface.ITemporaryCustomer)customer).InterfaceMethod();

            explicitInterface.Customer2 customer2 = new explicitInterface.Customer2();
            customer2.InterfaceMethod();
            ((explicitInterface.ITemporaryCustomer)customer2).InterfaceMethod();

            explicitInterface.Vehicle vehicle = new explicitInterface.Vehicle();
            ((explicitInterface.ILandVehicle)vehicle).Control();  
            ((explicitInterface.IWaterVehicle)vehicle).Control();

            explicitInterface.HybridVehicle hybridVechile = new explicitInterface.HybridVehicle();
            hybridVechile.Control();                 
            ((explicitInterface.IWaterVehicle)hybridVechile).Control(); 
        }

        public static void AbstractClassExample()
        {
            Abstract.Customer customer = new Abstract.Customer();
            customer.Print();

            Abstract.FullTimeEmployee ftEmployee = new Abstract.FullTimeEmployee();
            ftEmployee.Name = "John Doe";
            ftEmployee.MonthlySalary = 5000;

            Abstract.PartTimeEmployee ptEmployee = new Abstract.PartTimeEmployee();
            ptEmployee.Name = "Jane Smith";
            ptEmployee.HourlyWage = 20;
            ptEmployee.HoursWorked = 100;

            ftEmployee.DisplayEmployeeInfo();
            Console.WriteLine($"Salary: {ftEmployee.CalculateSalary()}");

            ptEmployee.DisplayEmployeeInfo();
            Console.WriteLine($"Salary: {ptEmployee.CalculateSalary()}");
        }

        public static void DaimondProblemExample()
        {
            Daimond.TemporaryCustomer customer = new Daimond.TemporaryCustomer();
            customer.Print();
        }

        public static void MultipleInheritanceExample()
        {
            Student student = new Student();
            student.ShowAcademicResult();       
            student.ShowSportsPerformance();

            SmartPhone smartPhone = new SmartPhone();
            smartPhone.TakePhoto();
            smartPhone.MakeCall();
        }

        public static void ParameterArrayExample()
        {
            ParameterArray parameterArray = new ParameterArray();
            parameterArray.AddNumbers(10, 20);
            parameterArray.AddNumbers(20, 30,50,30,40,10);
            parameterArray.AddNumbers(10, 20, new object[] { 10, 30, 50, 60 });

            parameterArray.ConcatenateStrings("Hello", "World");
            parameterArray.ConcatenateStrings("Good", "Morning", " ", "Everyone", "!");
            parameterArray.ConcatenateStrings("Hi", " ", "There", 123, "!", 45.6);
        }

        public static void MethodOverloadingExample()
        {
            MethodOverloading methodOverloading = new MethodOverloading();
            methodOverloading.AddNumbers(10, 20);
            methodOverloading.AddNumbers(10, 30, new int[] { 10,20,30});
            methodOverloading.CalculateArea(2);
            methodOverloading.CalculateArea(3,4);
            methodOverloading.CalculateArea(5, 10, true);
        }

        public static void ParameterDefaultExample()
        {
            ParameterDefault parameterDefault = new ParameterDefault();
            parameterDefault.AddNumbers(10, 20);
            parameterDefault.AddNumbers(10, 20, new int[] { 30, 20 });
            parameterDefault.Test(1);
            parameterDefault.Test(1, b: 3, c: 5);
        }

        public static void OptionalAttributeExample()
        {
            OptionalAttributeClass optionalAttribute = new OptionalAttributeClass();
            optionalAttribute.AddNumbers(10, 20);
            optionalAttribute.AddNumbers(10, 30, new int[] { 10, 20, 30, 50 });
            optionalAttribute.ConcatenateStrings("Hello", "World");
            optionalAttribute.ConcatenateStrings("Hello", "World", new string[] { " from", " C#" });
            optionalAttribute.CalculateTotalPrice(100.0, 5.0);
            optionalAttribute.CalculateTotalPrice(100.0, 5.0, new double[] { 5.0, 2.0 });
        }

        public static void OverrideStringExample()
        {
            OverrideString.OverrideToStringMethods Methods = new OverrideString.OverrideToStringMethods();
            Methods.OverrideToStringExample();
            Methods.ConvertToStringExample();
        }

        public static void StringsExample()
        {
            OverrideString.Strings strings = new OverrideString.Strings();
            strings.SysytemStringExample();
            strings.StringBuilderExample();
        }

        public static void VaribalesExample()
        {
            Variables variables = new Variables();
            Variables variables1 = new Variables();
            Variables variables2 = new Variables();
            Variables Variables3 = new Variables();
        }
    }
}
