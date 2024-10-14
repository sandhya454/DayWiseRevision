using System;

namespace Day33Concepts.DaimondProblem
{
    class Customer
    {
        public virtual void Print()
        {
            Console.WriteLine("Cutomer Implementation");
        }
    }

    class RegularCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("RegularCustomer Implementation");
        }
    }

    class WholeSaleCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("WholesaleCustomer Implementation");
        }
    }

    //Cause the daimond problem
    //class TemporaryCustomer : RegularCustomer,WholeSaleCustomer
    //{
    //}

    class TemporaryCustomer : RegularCustomer
    {
    }
}
