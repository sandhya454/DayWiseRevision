using System;

namespace Day32Concepts.MethodOverridingAndHiding
{
    public class BaseClass
    {
        public void Print()
        {
            Console.WriteLine($"This is Print Method from Base Class");
        }

        public virtual void PrintName()
        {
            Console.WriteLine($"This is Print Name Method from Base Class");
        }
    }

    public class DerivedClass : BaseClass
    {
        public new  void Print()
        {
            Console.WriteLine($"This is Print Method From Derived Class");
        }

        public override void PrintName()
        {
            Console.WriteLine($"Print Name Method From Derived Class");
        }
    }
}
