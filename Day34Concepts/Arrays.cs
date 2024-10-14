using System;

namespace Day34Concepts.Arrays
{
    public class ArrayExamples
    {
        public void ArrayDeclaration()
        {
            string[] cars = new string[3] { "Volvo", "BMW", "Ford" };
            int[] myNumbers = new int[3] { 10, 20, 30 };
            string[] cars1 = { "Volvo", "BMW", "Ford" };
            string[] cars2 = new string[10];
            cars2[0] = "Volvo";
            cars2[1] = "BMW";
            cars2[2] = "Ford";
        }

        public void PrintArrayByLoops()
        {
            string[] planetsArray = { "Mecury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            Console.WriteLine("Printing by foreach loop");
            foreach (string planet in planetsArray)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("Printing Array by forloop");
            for (int i = 0; i < planetsArray.Length; i++)
            {
                Console.WriteLine(planetsArray[i]);
            }
        }

        public void PrintPlanetByNumber()
        {
            string[] planetsArray = { "Mecury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            Console.WriteLine("Enter 1-8 any number to see the planet");

            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(planetsArray[userNumber - 1]);
        }

        public void ArrayReverseMethod()
        {
            string[] planetsArray = { "Mecury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            Array.Reverse(planetsArray);

            Console.WriteLine("Printig in Reverse");
            foreach (string planet in planetsArray)
            {
                Console.WriteLine(planet);
            }
        }

        public void ArraySortMethod()
        {
            string[] planetsArray = { "Mecury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            Array.Sort(planetsArray);

            Console.WriteLine("Printig by sort method");
            foreach (string planet in planetsArray)
            {
                Console.WriteLine(planet);
            }
        }

        public void ArrayExsistMethod()
        {
            string[] planetsArray = { "Mecury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            bool isEarthExist = Array.Exists(planetsArray, x => x == "Earth");
            Console.WriteLine($"\n Is Mars Exists:{isEarthExist}");
        }

        public void ArrayIndexOfExample()
        {
            string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Fig" };

            int index = Array.IndexOf(fruits, "Cherry");

            if (index >= 0)
            {
                Console.WriteLine($"'Cherry' found at index: {index}");
            }
            else
            {
                Console.WriteLine("'Cherry' not found in the array.");
            }
        }

        public void ArrayClearExample()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original Array:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Array.Clear(numbers, 1, 3);

            Console.WriteLine("\nArray after Clear:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void ArrayResizeExample()
        {
            int[] numbers = { 1, 2, 3 };

            Console.WriteLine("Original Array:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Resize the array to a larger size (5)
            Array.Resize(ref numbers, 5);

            Console.WriteLine("\nArray after Resize (Larger):");
            foreach (int number in numbers)
            {
                // New elements will have default value (0)
                Console.WriteLine(number);
            }

            // Resize the array to a smaller size (2)
            Array.Resize(ref numbers, 2);

            Console.WriteLine("\nArray after Resize (Smaller):");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void ArrayFindExample()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int result = Array.Find(numbers, element => element > 3);

            Console.WriteLine($"First element greater than 3: {result}");
        }

        public void ArrayFindAllExample()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int[] result = Array.FindAll(numbers, element => element > 3);

            Console.WriteLine("Elements greater than 3:");
            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
