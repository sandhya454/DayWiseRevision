using System;
using Day34Concepts.WhyEnums;
using Day34Concepts.EnumsExamplesAndAdvantages;
using Day34Concepts.EnumsConcepts;
using Day34Concepts.ExceptionHandling;
using Day34Concepts.ExceptionTypes;
using Day34Concepts.AsynchronousProgramming;
using Day34Concepts.DebugVsRelease;
using Day34Concepts.Arrays;
using Day34Concepts.ArrayComparisons;

namespace Day34Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WithoutEnumExample();
            //EnumExamples();
            //EnumConceptsExample();
            //ExceptionHandlingExamples();
            //ExceptionTypesExamples();
            //AsynchronusProgrammingExample();
            //DebugVsReleadeExample();
            //ArrayExamples();
            ArrayComparisonExamples();
        }

        public static void WithoutEnumExample()
        {
            WithoutEnums withoutEnums = new WithoutEnums();
            withoutEnums.PrintCustomer();
        }
        public static void EnumExamples()
        {
            EnumsExamples enumsExamples = new EnumsExamples();
            enumsExamples.PrintCustomers();
            enumsExamples.EnumsWithExplicitWithValues();
            enumsExamples.EnumsWithClassExample();
            enumsExamples.EnumWithDictionaryExample();
            enumsExamples.EnumWithStructExample();
        }

        public static void EnumConceptsExample()
        {
            Enums enumsExamples = new Enums();
            enumsExamples.PrintTypeAndValues();
        }

        public static void ExceptionHandlingExamples()
        {
            Examples examples = new Examples();
            examples.ExceptionHandlingExample();
            examples.DivideByZeroException();
            examples.CatchingMultipleExceptions();
            examples.ThrowingExceptions();
        }

        public static void ExceptionTypesExamples()
        {
            ExceptionTypesExamples examples = new ExceptionTypesExamples();
            examples.BasicExample();
            examples.ProcessString();

            EmailValidator emailValidator = new EmailValidator();
            emailValidator.ProcessEmail();

            LibrarySystem librarySystem = new LibrarySystem();
            librarySystem.ProcessLending("The Great Gatsby");
        }

        public static void AsynchronusProgrammingExample()
        {
            AsynchronusExample example = new AsynchronusExample();
            example.ThreadExample();
            example.TaskExample();
            example.AsyncAwaitExample();

            StringAsyncExample stringExample = new StringAsyncExample();
            stringExample.RunStringTask();

            PersonAsyncExample classExample = new PersonAsyncExample();
            classExample.RunPersonTask();

            ListAsyncExample listExample = new ListAsyncExample();
            listExample.RunListTask();

            DictionaryAsyncExample dictionaryExample = new DictionaryAsyncExample();
            dictionaryExample.RunDictionaryTask();
        }

        public static void DebugVsReleadeExample()
        {
            MainClass mainClass = new MainClass();
            mainClass.Example();
            mainClass.DisplayApp();

            DebugReleaseExample releaseExample = new DebugReleaseExample();
            releaseExample.Run();
        }

        public static void ArrayExamples()
        {
            ArrayExamples examples = new ArrayExamples();
            examples.PrintArrayByLoops();
            examples.PrintPlanetByNumber();
            examples.ArrayReverseMethod();
            examples.ArraySortMethod();
            examples.ArrayExsistMethod();
            examples.ArrayIndexOfExample();
            examples.ArrayClearExample();
            examples.ArrayResizeExample();
            examples.ArrayFindExample();
            examples.ArrayFindAllExample();
        }

        public static void ArrayComparisonExamples()
        {
            Comparisons comparisons = new Comparisons();
            comparisons.ArrayComparisonMethodExample();
            comparisons.ArrayComparisonByPredefined();
            comparisons.ArrayComparisonPrimitiveTypes();
            comparisons.ArrayComparisonStrings();
            comparisons.ArrayComparisonNullableTypes();
            comparisons.ArrayComparisonComplexTypes();
        }
    }
}
