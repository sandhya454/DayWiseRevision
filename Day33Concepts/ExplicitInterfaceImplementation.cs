using System;

namespace Day33Concepts.ExplicitInterfaceImplementation
{
    interface IRegularCustomer
    {
        void InterfaceMethod();
    }

    interface ITemporaryCustomer
    {
        void InterfaceMethod();
    }

    class Customer : IRegularCustomer, ITemporaryCustomer
    {
        void IRegularCustomer.InterfaceMethod()
        {
            Console.WriteLine("Interface Implemenatation I1");
        }
        void ITemporaryCustomer.InterfaceMethod()
        {
            Console.WriteLine("Interface Implemenatation I2");
        }
    }

    class Customer2 : IRegularCustomer, ITemporaryCustomer
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("Interface Implemenatation I1");
        }

        void ITemporaryCustomer.InterfaceMethod()
        {
            Console.WriteLine("Interface Implemenatation I2");
        }
    }

    interface ILandVehicle
    {
        void Control();
    }

    interface IWaterVehicle
    {
        void Control();
    }

    class Vehicle : ILandVehicle, IWaterVehicle
    {
        void ILandVehicle.Control()
        {
            Console.WriteLine("Controlling as a Land Vehicle");
        }

        void IWaterVehicle.Control()
        {
            Console.WriteLine("Controlling as a Water Vehicle");
        }
    }

    class HybridVehicle : ILandVehicle, IWaterVehicle
    {
        public void Control()
        {
            Console.WriteLine("Controlling as a Land Vehicle via public method");
        }

        void IWaterVehicle.Control()
        {
            Console.WriteLine("Controlling as a Water Vehicle via explicit interface method");
        }
    }
}
