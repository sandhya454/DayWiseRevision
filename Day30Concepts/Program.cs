using System;
using System.Collections.Generic;
using Day30Concepts.CommonOperators;
using Day30Concepts.ConditionalStatements;
using Day30Concepts.LoopStatements;
using Day30Concepts.Methods;
using Day30Concepts.MethodParameters;
using Day30Concepts.Tuples;

namespace Day30Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OperatorsExample();
            //ConditionalStatementsExample();
            //LoopStatementsExample();
            //MethodsExamples();
            //MethodParametersExample();
            TuplesExamples();
        }

        public static void OperatorsExample()
        {
            Operators operators = new Operators();
            operators.OperatorExampleforInt();
            operators.OperatorExampleForFloat();
            operators.OperatorExampleForDouble();
            operators.OperatorExampleForChar();
            operators.OperatorExampleForString();
            operators.NullCoalesingOperatorExample();
            operators.PrintNameUsingNullCoelascing();
        }

        public static void ConditionalStatementsExample()
        {
            Statements statements = new Statements();
            statements.IfStatementExample();
            statements.IfElseStatementExample();
            statements.CheckingTemperature();
            statements.SwitchStatementExample();
            statements.SelectingVechicle();
            statements.CoffeePurchase();
        }

        public static void LoopStatementsExample()
        {
            Loops loops = new Loops();
            loops.WhileExample();
            loops.AtmPinVerification();
            loops.DoWhileExample();
            loops.CoffeePurchaseExampleUsingDoWhile();
            loops.BankingMenuApplication();
            loops.IteratingArrayByLoops();
            loops.PrintTables();
            loops.IterateStringArray();
            loops.IterateLists();
            loops.BreakAndContinueExample();
        }

        public static void MethodsExamples()
        {
            MethodExamples.StaticMethod();

            MethodExamples methodExamples = new MethodExamples();
            int result = methodExamples.Add(5, 10);
            Console.WriteLine(result);

            string fullName= methodExamples.PrintName();
           Console.WriteLine(fullName);

            double area = methodExamples.CalculateArea(4);
            Console.WriteLine(area);

            bool isEven = methodExamples.IsEven(5);
            Console.WriteLine(isEven);

            List<string> names = methodExamples.GetNames();
            Console.WriteLine("Names in the list:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static void MethodParametersExample()
        {
            int number = 20;
            Console.WriteLine($"Before calling ModifyValue: {number}");

            Parameters parameters = new Parameters();
            parameters.PassByValue(number);
            Console.WriteLine($"After calling ModifyValue: {number}");

            parameters.PassByReference(ref number);
            Console.WriteLine($"After calling ModifyValue: {number}");

            int totalSum = 0;
            int totalProduct = 0;
            parameters.OutPutParameterExample(10, 20, out totalSum, out totalProduct);
            Console.WriteLine(totalSum);
            Console.WriteLine(totalProduct);

            int[] numbers = new int[] { 1, 2, 3, 4 };
            parameters.ParamsMethodExample(numbers);
            parameters.ParamsMethodExample(1,2,5);
        }

        public static void TuplesExamples()
        {
            Examples examples = new Examples();
            examples.TupleDeclarationExample();
        }
    }
}
