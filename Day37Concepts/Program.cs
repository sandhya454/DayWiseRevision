using System;
using Day37Concepts.LinqQueryTypes;
using Day37Concepts.ExtensionMethods;
using Day37Concepts.ProjectionMethods;
using Day37Concepts.FilteringOperators;
using Day37Concepts.SortingOperators;

namespace Day37Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinqQueryTypesExample();
            //ExtensionMethodExamples();
            //SelectMethodExample();
            //SelectManyMethodExamples();
            //WhereMethodExample();
            //OffTypeMethodExample();
            //OrderByMethodExample();
            //OrderByDescedingExample();
            ReverseMethodExample();
        }

        public static void LinqQueryTypesExample()
        {
            QueryTypes queryTypes = new QueryTypes();
            queryTypes.QuerySyntax();
            queryTypes.MethodSyntax();
            queryTypes.MixedSyntax();
        }

        public static void ExtensionMethodExamples()
        {
            Examples examples = new Examples();
            examples.ChangeStringFirstLetter();
            examples.CheckingPalindrome();
            examples.CheckingNumberIsEven();
            examples.FindSecondLargestNumber();
        }

        public static void SelectMethodExample()
        {
            SelectMethod selectMethod = new SelectMethod();
            selectMethod.BasicExample();
            selectMethod.SelectOneProperty();
            selectMethod.SelectManyProperties();
            selectMethod.AssignDataToOtherClass();
            selectMethod.AssignDataToAnanymousType();
            selectMethod.SelectDataByUsingIndex();
        }

        public static void SelectManyMethodExamples()
        {
            SelectManyMethod selectManyMethod = new SelectManyMethod();
            //selectManyMethod.SlectManyMethodForLists();
            //selectManyMethod.SelectManyMethodForClasses();
            selectManyMethod.SelectManyMethodExample();
        }

        public static void WhereMethodExample()
        {
            WhereMethod whereMethod = new WhereMethod();
            whereMethod.IntegerExample();
            whereMethod.IntegerExampleWithMultipleConditions();
            whereMethod.StringExample();
            whereMethod.StringExampleWithMultipleConditions();
            whereMethod.ClassExample();
        }

        public static void OffTypeMethodExample()
        {
            OfTypeMethod ofTypeMethod = new OfTypeMethod();
            ofTypeMethod.OfTypeMethodExample();
            ofTypeMethod.OfTypeWithCondition();
            ofTypeMethod.OfTypeExampleForClass();
            ofTypeMethod.OfTypeExampleForClassWithCondition();
        }

        public static void OrderByMethodExample()
        {
            OrderByMethod orderByMethod = new OrderByMethod();
            orderByMethod.IntegerExample();
            orderByMethod.StringExample();
            orderByMethod.ObjectExample();
        }

        public static void OrderByDescedingExample()
        {
            OrderByDescending orderByDescending = new OrderByDescending();
            //orderByDescending.IntegerExample();
            //orderByDescending.StringExample();
            orderByDescending.ClassExample();
        }

        public static void ReverseMethodExample()
        {
            ReverseMethod reverseMethod = new ReverseMethod();
            reverseMethod.IntegerExample();
            reverseMethod.StringExample();
            reverseMethod.ClassExample();
        }
    }
}
