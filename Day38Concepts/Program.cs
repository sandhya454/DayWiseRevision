using System;
using Day38Concepts.QuantifierOperations;
using Day38Concepts.SetOperations;
using Day38Concepts.PartitioningOperators;
using Day38Concepts.ElementOperations;

namespace Day38Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AllMethodExample();
            //AnyMethodExample();
            //ContainsMethodExample();
            //CombinedAllMethodsExamples();
            //DistinctMethodExample();
            //ExceptMethodExample();
            //IntersectMethodExample();
            //UnionMethodExample();
            //TakeMethodExample();
            //TakeWhileMethodExample();
            //SkipMethodExample();
            //SkipWhileMethodExample();
            //PartioningOperatorsForComplexType();
            //FirstVsFirstOrDefaultExample();
            //LastVsLastOrDefaultExample();
            SingleVsSingleOrDefaultExample();
        }

        public static void AllMethodExample()
        {
            AllMethod allMethod = new AllMethod();
            allMethod.AllMethodExample();
            allMethod.AllMethodExampleWithWhere();
            allMethod.AllMethodForIntegerList();
        }

        public static void AnyMethodExample()
        {
            AnyMethod anyMethod = new AnyMethod();
            anyMethod.AnyMethodExample();
            anyMethod.AnyMethodExampleWithWhere();
        }

        public static void ContainsMethodExample()
        {
            ContainsMethod containsMethod = new ContainsMethod();
            containsMethod.ContainsMethodExample();
            containsMethod.ConatinsMethodForComplexType();
        }

        public static void CombinedAllMethodsExamples()
        {
            CombinedExamples combinedExamples = new CombinedExamples();
            combinedExamples.CombinedExamplesForDateAndTime();
            combinedExamples.CombinedExamplesForDouble();
            combinedExamples.CombinedExamplesForString();
        }

        public static void DistinctMethodExample()
        {
            DistinctMethod distinctMethod = new DistinctMethod();
            distinctMethod.DistnictMethodOnSimpleList();
            distinctMethod.DistinctForIEquitableClass();
            distinctMethod.DistinctForIEqualityClass();
        }

        public static void ExceptMethodExample()
        {
            ExceptMethod exceptMethod = new ExceptMethod();
            exceptMethod.ExceptMethodForLists();
            exceptMethod.ExceptMethodForOneProperty();
            exceptMethod.ExceptMethodUsingAnanymous();
            exceptMethod.ExceptMethodUsingComaparer();
        }

        public static void IntersectMethodExample()
        {
            IntersectMethod intersectMethod = new IntersectMethod();
            intersectMethod.IntersectMethodForLists();
            intersectMethod.IntersectMethodUsingAnanymous();
            intersectMethod.IntersectMethodUsingComparer();
        }

        public static void UnionMethodExample()
        {
            UnionMethod unionMethod = new UnionMethod();
            unionMethod.UnionMethodForList();
            unionMethod.UnionMethodUsingAnanymousWay();
            unionMethod.UnionMethodUsingComparer();
        }

        public static void TakeMethodExample()
        {
            TakeMethod takeMethod = new TakeMethod();
            takeMethod.TakeMethodExample();
            takeMethod.TakeMethodWithFilterExample();
        }

        public static void TakeWhileMethodExample()
        {
            TakeWhileMethod takeWhileMethod = new TakeWhileMethod();
            takeWhileMethod.TakeWhileMethodForIntList();
            takeWhileMethod.TakeWhileMethodForString();
        }

        public static void SkipMethodExample()
        {
            SkipMethod skipMethod = new SkipMethod();
            skipMethod.SkipMethodExample();
        }

        public static void SkipWhileMethodExample()
        {
            SkipWhileMethod skipWhileMethod = new SkipWhileMethod();
            skipWhileMethod.SkipWhileForIntegers();
            skipWhileMethod.SkipWhileForStrings();
        }

        public static void PartioningOperatorsForComplexType()
        {
            ComplexExample complexExample = new ComplexExample();
            complexExample.PartioningOperatorsForComplexExample();
        }

        public static void FirstVsFirstOrDefaultExample()
        {
            FirstVsFirstOrDefault firstVsFirstOrDefault = new FirstVsFirstOrDefault();
            firstVsFirstOrDefault.FirstMethodExample();
            firstVsFirstOrDefault.FirstOrDefaultMethod();
            firstVsFirstOrDefault.ComplexExampleForFirstMethod();
        }

        public static void LastVsLastOrDefaultExample()
        {
            LastVsLastOrDefault lastVsLastOrDefault = new LastVsLastOrDefault();
            lastVsLastOrDefault.LasttMethod();
            lastVsLastOrDefault.LastOrDefaultMethod();
            lastVsLastOrDefault.ComplexExample();
        }

        public static void SingleVsSingleOrDefaultExample()
        {
            SingleVsSingleOrDefault singleVsSingleOrDefault = new SingleVsSingleOrDefault();
            singleVsSingleOrDefault.SingleMethodWithCondition();
            singleVsSingleOrDefault.ComplexExample();
        }
    }
}
