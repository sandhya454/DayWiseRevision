using System;

namespace Day29Concepts.BuiltInDataTypes
{
    public class DataTypes
    {
        /// <summary>
        /// DataType defines the size and typeof data which is stored
        /// and we have 2 types value types and reference types
        /// for value types we have int,long,float,double,decimal,bool
        /// and reference types we have string,array,object etc.,
        /// </summary>
        public void IntegerExample()
        {
            int number = 12;

            Console.WriteLine(number);
            Console.WriteLine($"the size of the int type is {sizeof(int)}");
            Console.WriteLine($"Min value of the int is {int.MinValue}");
            Console.WriteLine($"Max value of the int is {int.MaxValue}");
        }

        public void LongExample()
        {
            long number = 128787;

            Console.WriteLine(number);
            Console.WriteLine($"the size of the long type is {sizeof(long)}");
            Console.WriteLine($"Min value of the long is {long.MinValue}");
            Console.WriteLine($"Max value of the long is {long.MaxValue}");
        }

        public void FloatExample()
        {
            float number = 23.455f;

            Console.WriteLine(number);
            Console.WriteLine($"the size of the float type is {sizeof(float)}");
            Console.WriteLine($"Min value of the float is {float.MinValue}");
            Console.WriteLine($"Max value of the float is {float.MaxValue}");
        }

        public void DoubleExample()
        {
            double number = 23.455;

            Console.WriteLine(number);
            Console.WriteLine($"the size of the double type is {sizeof(double)}");
            Console.WriteLine($"Min value of the double is {double.MinValue}");
            Console.WriteLine($"Max value of the double is {double.MaxValue}");
        }

        public void DecimalExample()
        {
            decimal number = 21.3445m;

            Console.WriteLine(number);
            Console.WriteLine($"the size of the decimal type is {sizeof(decimal)}");
            Console.WriteLine($"Min value of the decimal is {decimal.MinValue}");
            Console.WriteLine($"Max value of the decimal is {decimal.MaxValue}");
        }

        public void BoolExample()
        {
            bool isValid = true;

            Console.WriteLine(isValid);
            Console.WriteLine($"the size of the bool type is {sizeof(bool)}");
        }

        public void CharExample()
        {
            char c = 'a';

            Console.WriteLine(c);
            Console.WriteLine($"the size of the char type is {sizeof(char)}");
        }

        public void StringExample()
        {
            string firstName = "Savar";
            string lastName = "Technologies";

            Console.WriteLine($"Name is {firstName} {lastName}");
        }
    }
}
