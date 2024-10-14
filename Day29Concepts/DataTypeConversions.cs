using System;

namespace Day29Concepts.DataTypeConversions
{
    public class Conversions
    {
        /// <summary>
        /// if there is no loss of information after conversion
        /// then we can say it as a implicit conversion
        /// </summary>
        public void ImplictConversion()
        {
            int number = 100;
            Console.WriteLine(number);

            long number1 = number;
            float number2 = number;
            double number3 = number;
            decimal number4 = number;

            Console.WriteLine("After Conversion");
            Console.WriteLine(number1);
            Console.WriteLine(number2);

            char character = 'A';
            int character1 = character;
            float character2 = character;
            double character3 = character;
            decimal character4 = character;

            float temperature = 23.4f;
            double temperature1 = temperature;

        }

        /// <summary>
        /// if thers is some loss of information after conversion
        /// the we can say it as a explicit conversion and these can be done in
        /// two ways - by using type cast () and by using Convert Class
        /// </summary>
        public void ExplicitConversion()
        {
            float number = 123.67f;
            Console.WriteLine(number);

            long number1=(long)number;
            int number2=Convert.ToInt32(number);
            double number3=(double)number;
            decimal number4=(decimal)number;

            Console.WriteLine("After Conversion");
            Console.WriteLine(number1);
            Console.WriteLine(number2);

            double percentage = 23.753;
            float percentage1=(float)percentage;
            decimal percentage2=(decimal)percentage;
            int percentage3=(int)percentage;
            long percentage4=(long)percentage;

            Console.WriteLine("After Conversion");
            Console.WriteLine(percentage1);
            Console.WriteLine(percentage2);
            Console.WriteLine(percentage3);
            Console.WriteLine(percentage4);

            decimal temperature = 20.89m;
            float temperature1=(float)temperature;
            int temperature2=(int)temperature;
            long temperature3=(long)temperature;
        }

        /// <summary>
        /// when we are converting to store max val of long into int 
        /// if we are using typecast operator it will give min value -1
        /// if we are using convert class it will throw overflow exception.
        /// </summary>
        public void DiffernceBwImplicitAndExpllicit()
        {
            long maxValue = long.MaxValue;
            Console.WriteLine(maxValue);

            int maxValue2 = (int) maxValue;
            Console.WriteLine(maxValue2);

            //int maxValue3 = Convert.ToInt32(maxValue);
            //Console.WriteLine(maxValue3);
        }

        /// <summary>
        /// if we are converting the value type to reference type 
        /// then it is called as a boxing and it uses implict process
        /// </summary>
        public void Boxing()
        {
            int number = 100;
            Console.WriteLine(number);

            object number1 = number;
            Console.WriteLine("After Boxing");
            Console.WriteLine(number1);
        }

        /// <summary>
        /// if we are converting reference type to value type 
        /// then it is called as unboxing and it uses explicit conversion
        /// </summary>
        public void UnBoxing()
        {
            object number = 1000;
            Console.WriteLine(number);

            int number1=(int)number;
            Console.WriteLine("After UnBoxing");
            Console.WriteLine(number1);
        }

        /// <summary>
        /// if we enetered a character in command prompt if we are using parse method 
        /// it throws an exception while tryparse method returns default value of the type
        /// </summary>
        public void ParseAndTryParse()
        {
            Console.WriteLine("Enter First Number:");
            int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Enter Second Number:");
            int secondNumber=int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");
        }
    }
}
