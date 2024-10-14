using System;

namespace Day29Concepts.ConsoleConcepts
{
    public class ConsoleMethods
    {
        /// <summary>
        /// It will print the next output into the  next line
        /// </summary>
        public void WriteLineExample()
        {
            Console.WriteLine("Welcome To");
            Console.WriteLine("Savar Technologies");
        }

        /// <summary>
        /// It will print next output into the same line
        /// </summary>
        public void WriteExample()
        {
            Console.Write("Welcome to");
            Console.Write("Savar Technologies");
        }

        /// <summary>
        /// it will read the group of characters from command prompt
        /// and returns string
        /// </summary>
        public void ReadLineExample()
        {
            Console.WriteLine("Enter Name:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Provided Name is :{userName}");
        }

        /// <summary>
        /// Read method rreads the single value from the command prompt
        /// and returns the ASCII value in integer type
        /// </summary>
        public void ReadExample()
        {
            Console.WriteLine("Enter a Character");
            int value = Console.Read();
            Console.WriteLine($"ASCII value of character is :{value}");
        }

        public void CombiningWordsExample()
        {
            Console.WriteLine("Enter FirstName:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter LastName:");
            string lastName = Console.ReadLine();

            //Concatination
            Console.WriteLine("Entered FirstName is" + firstName + "and LastName is " + lastName);

            //PlaceHolder
            Console.WriteLine("Entered FirstName is {0} and LastName is {1}", firstName, lastName);

            //Interpolation
            Console.WriteLine($"Entered FirstName is {firstName} and LastName is {lastName}");
        }
    }
}
