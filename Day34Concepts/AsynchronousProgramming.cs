using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Day34Concepts.AsynchronousProgramming
{
    public class AsynchronusExample
    {
        public void ThreadExample()
        {
            Thread threadOne = new Thread(new ThreadStart(FunctionOne));
            Thread threadTwo = new Thread(new ThreadStart(FunctionTwo));
            threadOne.Start();
            threadTwo.Start();
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }

        public void TaskExample()
        {
            Task threadOne = new Task(FunctionOne);
            Task threadTwo = new Task(FunctionTwo);
            threadOne.Start();
            threadTwo.Start();
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }

        public void AsyncAwaitExample()
        {
            FirstFunction();
            SecondFunction();
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }

        public void FunctionOne()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Fun 1:-{i}");
            }
        }

        public void FunctionTwo()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Fun 1:-{i}");
            }
        }

        public async void FirstFunction()
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine($"Fun 1:-{i}");
            }
        }

        public async void SecondFunction()
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine($"Fun 2:-{i}");
            }
        }
    }

    public class StringAsyncExample
    {
        public void RunStringTask()
        {
            Task.Run(() => ProcessStringsAsync()).Wait();
        }

        private async Task ProcessStringsAsync()
        {
            string[] words = { "apple", "banana", "cherry" };

            foreach (string word in words)
            {
                await Task.Delay(500);
                Console.WriteLine($"Processed word: {word.ToUpper()}");
            }
        }
    }

    public class ListAsyncExample
    {
        public void RunListTask()
        {
            Task.Run(() => ProcessListAsync()).Wait();
        }

        private async Task ProcessListAsync()
        {
            List<double> values = new List<double> { 1.1, 2.2, 3.3, 4.4 };

            foreach (double value in values)
            {
                await Task.Delay(400);
                Console.WriteLine($"Processed value: {Math.Round(value * value, 2)}");
            }
        }
    }

    public class DictionaryAsyncExample
    {
        public void RunDictionaryTask()
        {
            Task.Run(() => ProcessDictionaryAsync()).Wait();  
        }

        private async Task ProcessDictionaryAsync()
        {
            Dictionary<string, int> data = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 3 }
        };

            foreach (var entry in data)
            {
                await Task.Delay(500); 
                Console.WriteLine($"Processed key: {entry.Key}, value: {entry.Value * 2}");
            }
        }
    }

    public class PersonAsyncExample
    {
        public void RunPersonTask()
        {
            Task.Run(() => ProcessPersonsAsync()).Wait(); 
        }

        private async Task ProcessPersonsAsync()
        {
            Person[] people =
            {
            new Person { Name = "John", Age = 30 },
            new Person { Name = "Jane", Age = 25 }
        };

            foreach (var person in people)
            {
                await Task.Delay(500); 
                Console.WriteLine($"Processed person: {person.Name}, Age: {person.Age}");
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
