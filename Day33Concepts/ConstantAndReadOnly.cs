using System;

namespace Day33Concepts.ConstantAndReadOnly
{
    public class Variables
    {
        static int number = 1;
        readonly int number2 = 6;
        const int number3 = 30;
        int number4 = 5;

        public Variables()
        {
            number++;
            number2++;
            number4++;
            Console.WriteLine($"static variable  {number}");
            Console.WriteLine($"ReadOnly Variable {number2}");
            Console.WriteLine($"Without static Variable {number4}");
            Console.WriteLine($"Constant variable {number3}");
        }
    }
}
