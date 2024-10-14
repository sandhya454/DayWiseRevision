using System;

namespace Day33Concepts.Interfaces
{
    interface IRegularCustomer
    {
        void Print();
    }

    interface ITemporaryCustomer
    {
        void Print2();
    }

    class Customer : IRegularCustomer, ITemporaryCustomer
    {
        public void Print()
        {
            Console.WriteLine("This is Interface Print Method");
        }

        public void Print2()
        {
            Console.WriteLine("This is Interface2 Print Method");
        }
    }

    interface IFullTimeEmployee
    {
        void Print1();
    }
    interface IPartTimeEmployee : IFullTimeEmployee
    {
        void Print2();
    }

    public class Employee : IPartTimeEmployee
    {
        public void Print2()
        {
            Console.WriteLine("This is Interface Print2 Method");
        }

        public void Print1()
        {
            Console.WriteLine("This is Interface Print1 Method");
        }
    }

    interface IPrinter
    {
        void Print();
    }

    interface IScanner
    {
        void Scan();
    }

    class MultiFunctionDevice : IPrinter, IScanner
    {
        public void Print()
        {
            Console.WriteLine("This is Printer Print Method");
        }

        public void Scan()
        {
            Console.WriteLine("This is Scanner Scan Method");
        }
    }

    interface ISmartPhone
    {
        void MakeCall();
    }

    interface ITablet : ISmartPhone
    {
        void BrowseWeb();
    }

    class SmartDevice : ITablet
    {
        public void MakeCall()
        {
            Console.WriteLine("This is SmartPhone MakeCall Method");
        }

        public void BrowseWeb()
        {
            Console.WriteLine("This is Tablet BrowseWeb Method");
        }
    }
}
