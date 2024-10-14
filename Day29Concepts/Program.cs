using System;
using Day29Concepts.ApplicationDebugging;
using Day29Concepts.ConsoleConcepts;
using Day29Concepts.BuiltInDataTypes;
using Day29Concepts.DataTypeConversions;
using Day29Concepts.ArraysConcepts;

namespace Day29Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DebuggingExample();
            //ConsoleMethodsExample();
            //VariablesExample();
            //DataTypesExample();
            //ConversionExample();
            ArrayExample();
        }
       
        public static void DebuggingExample()
        {
            Maths maths = new Maths();
            int addResult = maths.Add(10, 5);
            Console.WriteLine(addResult);

            int subResult=maths.Sub(10, 5);
            Console.WriteLine(subResult);
        }

        public static void ConsoleMethodsExample()
        {
            ConsoleMethods consoleMethods = new ConsoleMethods();
            consoleMethods.WriteLineExample();
            consoleMethods.WriteExample();
            consoleMethods.ReadLineExample();
            consoleMethods.ReadExample();
            consoleMethods.CombiningWordsExample();
        }

        public static void VariablesExample()
        {
            Variables variables = new Variables();
            variables.VariablesTypes();
        }

        public static void DataTypesExample()
        {
            DataTypes dataTypes = new DataTypes();
            dataTypes.IntegerExample();
            dataTypes.LongExample();
            dataTypes.FloatExample();
            dataTypes.DoubleExample();
            dataTypes.DecimalExample();
            dataTypes.BoolExample();
            dataTypes.CharExample();
            dataTypes.StringExample();
        }

        public static void ConversionExample()
        {
            Conversions conversions = new Conversions();
            conversions.ImplictConversion();
            conversions.ExplicitConversion();
            conversions.DiffernceBwImplicitAndExpllicit();
            conversions.Boxing();
            conversions.UnBoxing();
            conversions.ParseAndTryParse();
        }

        public static void ArrayExample()
        {
            Declarations declarations = new Declarations();
            declarations.IntegerArray();
            declarations.StringArray();
        }
    }
}
