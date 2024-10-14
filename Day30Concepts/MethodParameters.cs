using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts.MethodParameters
{
    public class Parameters
    {
        public void PassByValue(int number)
        {
            number = 30;
            Console.WriteLine($"Inside ModifyValue: {number}");
        }

        public void PassByReference(ref int number)
        {
            number = 30;
            Console.WriteLine($"Inside ModifyValue: {number}");
        }

        public void OutPutParameterExample(int firstNumber, int secondNumber, out int sum, out int product)
        {
            sum = firstNumber + secondNumber;
            product = firstNumber * secondNumber;
        }

        public void ParamsMethodExample(params int[] numbers)
        {
            Console.WriteLine($"There are{numbers.Length} elements ");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
