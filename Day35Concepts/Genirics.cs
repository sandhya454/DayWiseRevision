using System;
using System.Collections.Generic;

namespace Day35Concepts.Genirics
{
    public class Examples
    {
        public void WithOutGenerics()//todo
        {
            Calculator calculator = new Calculator();
            bool isEqual = calculator.AreEqual(10, 10);
            Console.WriteLine(isEqual);
        }

        public void WithGenerics()//todo
        {
            Calculator calculator = new Calculator();
            bool isEqual = calculator.AreEqual<int>(10, 10);
            Console.WriteLine(isEqual);
        }

        public void GeniricClassExample()
        {
            GenericClass<int> integerObject = new GenericClass<int>(10);
            integerObject.DisplayData();

            GenericClass<string> stringObject = new GenericClass<string>("Hello Generics");
            stringObject.DisplayData();
        }

        public void GeniricInterfaceExample()
        {
            IContainer<int> integerContainer = new Container<int>(42);
            Console.WriteLine(integerContainer.Value);

            IContainer<string> stringContainer = new Container<string>("Hello InterfaceGenirics");
            Console.WriteLine(stringContainer.Value);
        }

        public void GeniricsListExample()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }

    public class Calculator
    {
        public bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }

        public bool AreEqual(object value1, object value2)
        {
            return value1 == value2;
        }

        public bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    public class GenericClass<T>
    {
        public T data;

        public GenericClass(T value)
        {
            data = value;
        }

        public void DisplayData()
        {
            Console.WriteLine($"Data: {data}");
        }
    }

    public interface IContainer<T>
    {
        T Value { get; set; }
    }

    public class Container<T> : IContainer<T>
    {
        public T Value { get; set; }

        public Container(T value)
        {
            Value = value;
        }
    }
}
