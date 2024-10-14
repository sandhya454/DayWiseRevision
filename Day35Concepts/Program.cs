using System;
using Day35Concepts.Genirics;
using Day35Concepts.ListCollectionClass;
using Day35Concepts.ListClassFunctions;
using Day35Concepts.ListClassRanges;
using Day35Concepts.ListOfSimpleTypes;
using Day35Concepts.ListOfComplexTypes;
using Day35Concepts.ComparisonDeligateWithLists;
using Day35Concepts.Dictionaries;
using Day35Concepts.CustomTypeDictionary;
using Day35Concepts.SortedListsAndSortedDictionaries;
using Day35Concepts.GeniricStack;
using Day35Concepts.GeniricQueue;

namespace Day35Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GeniricsExamples();
            //ListCollectionClassExample();
            //ListFunctionsExamples();
            //RangeMethodExamples();
            //SimpleTypeExamples();
            //ComplexTypesExample();
            //ComparsionDeligateWithListsExample();
            //DictionariesExamples();
            //CustomDictionaryExample();
            //SortedListAndSortedDictionaryExample();
            //StackExamples();
            QueueExample();
        }

        public static void GeniricsExamples()
        {
            Examples examples = new Examples();
            examples.WithOutGenerics();
            examples.WithGenerics();
            examples.GeniricClassExample();
            examples.GeniricClassExample();
            examples.GeniricInterfaceExample();
            examples.GeniricsListExample();
        }

        public static void ListCollectionClassExample()
        {
            CollectionClassExample collectionExample = new CollectionClassExample();
            collectionExample.ListCollectionMethod();
        }

        public static void ListFunctionsExamples()
        {
            PredefinedMethods predefinedMethods = new PredefinedMethods();
            predefinedMethods.ListClassConatinsMethod();
            predefinedMethods.ContainsMethodForPrimitiveType();
            predefinedMethods.ConatinsMetthodsForStrings();
            predefinedMethods.ListClassExsitsMethod();
            predefinedMethods.ExistsMethodWithIntList();
            predefinedMethods.ExistsMethodWithStringList();
            predefinedMethods.ListClassFindMethods();
            predefinedMethods.FindMethodForDoubleList();
            predefinedMethods.FindMethodForDateAndTimeList();
            predefinedMethods.FindMethodForDictionary();
            predefinedMethods.ListClassFindAllMethod();
            predefinedMethods.FindAllForIntLists();
            predefinedMethods.FindAllForDateAndTimeLists();
            predefinedMethods.FindFirstAndLastIndexForListClass();
            predefinedMethods.ArrayToLists();
            predefinedMethods.ListToDictionaryExample();
            predefinedMethods.ManagePersonData();
        }

        public static void RangeMethodExamples()
        {
            RangeMethods rangeMethods = new RangeMethods();
            rangeMethods.AddRangeMethod();
            rangeMethods.GetRangeMethod();
            rangeMethods.InsertRangeMethod();
            rangeMethods.RemoveRangeMethod();
            rangeMethods.ManagingEmployeeData();
        }

        public static void SimpleTypeExamples()
        {
            SimpleTypeExamples simpleType = new SimpleTypeExamples();
            simpleType.MethodForIntegerLists();
            simpleType.MethodForStringLists();
            simpleType.MethodForBoolList();
            simpleType.MethodForDateAndTimeList();
        }

        public static void ComplexTypesExample()
        {
            ComplexTypesExamples complexTypes = new ComplexTypesExamples();
            complexTypes.SortMethodForComplexType();
            complexTypes.SortMethodForDateAndTime();
            complexTypes.SortMethodForCustomObject();
        }

        public static void ComparsionDeligateWithListsExample()
        {
            DeligateExamples deligateExamples = new DeligateExamples();
            deligateExamples.SortByUsingDeligate();
            deligateExamples.ReverseOrderSortingUsingDeligate();
        }

        public static void DictionariesExamples()
        {
            DictionaryExamples dictionaryExamples = new DictionaryExamples();
            dictionaryExamples.DictronaryCaseSensitive();
            dictionaryExamples.EnnumratingDictinoary();
            dictionaryExamples.DictionaryMethods();
        }

        public static void CustomDictionaryExample()
        {
            CustomDictionaryExample customDictionary = new CustomDictionaryExample();
            customDictionary.CustomTypeDicitionaryExample();
            customDictionary.DictionaryExample();
        }

        public static void SortedListAndSortedDictionaryExample()
        {
            SortedDictionaryExamples sortedDictionary = new SortedDictionaryExamples();
            sortedDictionary.SortedDictionaryExample();
            sortedDictionary.DisplaySortedDictionary();

            SortedListsExamples sortedLists = new SortedListsExamples();
            sortedLists.SortedListsExample();
            sortedLists.DisplaySortedLists();
        }

        public static void StackExamples()
        {
            StackExample stackExample = new StackExample();
            stackExample.ShoppingCartUsingStack();
        }

        public static void QueueExample()
        {
            QueueExample queueExample = new QueueExample();
            queueExample.QueueMethodExample();
        }
    }
}
