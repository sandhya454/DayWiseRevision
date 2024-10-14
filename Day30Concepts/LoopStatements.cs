using System;
using System.Collections.Generic;

namespace Day30Concepts.LoopStatements
{
    public class Loops
    {
        public void WhileExample()
        {
            Console.WriteLine("Enter your Traget");
            int userTarget = int.Parse(Console.ReadLine());
            int start = 0;

            while (start < userTarget)
            {
                Console.Write(start + " ");
                start += 2;
            }
        }

        public void AtmPinVerification()
        {
            int correctPin = 1234;
            int enteredPin;
            int attempts = 0;
            int maxAttempts = 3;

            while (attempts < maxAttempts)
            {
                Console.WriteLine("Please enter your 4-digit PIN:");
                enteredPin = int.Parse(Console.ReadLine());
                attempts++;

                if (enteredPin == correctPin)
                {
                    Console.WriteLine("PIN correct. Access granted.");
                }
                else
                {
                    Console.WriteLine($"Incorrect PIN. You have {maxAttempts - attempts} attempt(s) left.");
                }

                if (attempts == maxAttempts && enteredPin != correctPin)
                {
                    Console.WriteLine("Maximum attempts reached. Your account is locked.");
                }
            }
        }

        public void DoWhileExample()
        {
            string userChoice = string.Empty;

            do
            {
                Console.WriteLine("Enter Your Target?");
                int userTarget = int.Parse(Console.ReadLine());
                int start = 0;

                while (start <= userTarget)
                {
                    Console.Write(start + " ");
                    start += 2;
                }
                do
                {
                    Console.WriteLine("Do You Want to Continue say : Yes or No");
                    userChoice = Console.ReadLine().ToUpper();

                    if (userChoice != "YES" && userChoice != "NO")
                    {
                        Console.WriteLine("Enter Valid Choice YES or NO");
                    }
                } while (userChoice != "YES" && userChoice != "NO");
            } while (userChoice == "YES");
        }

        public void CoffeePurchaseExampleUsingDoWhile()
        {
            string userDecision;
            int totalCost = 0;
            do
            {
                int userCofee;
                do
                {
                    Console.WriteLine("Enter your Coffee - 1-small 2-medium 3-large");
                    userCofee = int.Parse(Console.ReadLine());

                    switch (userCofee)
                    {
                        case 1:
                            totalCost += 1;
                            break;
                        case 2:
                            totalCost += 2;
                            break;
                        case 3:
                            totalCost += 3;
                            break;
                        default:
                            Console.WriteLine($"Your Choice {userCofee} is Invalid enter");
                            break;
                    }
                } while (userCofee != 1 && userCofee != 2 && userCofee != 3);

                do
                {
                    Console.WriteLine("Do you Want to Buy Another Coffee Say YES or NO :");
                    userDecision = Console.ReadLine().ToUpper();
                    if (userDecision != "YES" && userDecision != "NO")
                    {
                        Console.WriteLine($"Your Decision {userDecision} is not valid");
                    }
                } while (userDecision != "YES" && userDecision != "NO");
            } while (userDecision == "YES");

            Console.WriteLine("Thankyou for shopping with us");
            Console.WriteLine($"Your bill is {totalCost}$");
        }

        public void BankingMenuApplication()
        {
            int userChoice;
            string userDecision;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Funds");
                Console.WriteLine("3. Withdraw Funds");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter your choice (1-4):");
                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Your balance is $5000.");
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount to deposit:");
                        int deposit = int.Parse(Console.ReadLine());
                        Console.WriteLine($"You have deposited ${deposit}.");
                        break;
                    case 3:
                        Console.WriteLine("Enter the amount to withdraw:");
                        int withdrawal = int.Parse(Console.ReadLine());
                        Console.WriteLine($"You have withdrawn ${withdrawal}.");
                        break;
                    case 4:
                        Console.WriteLine("Exiting the application.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select an option between 1 and 4.");
                        break;
                }
                
                do
                {
                    Console.WriteLine("Do you Want to View Menu Say yes or no :");
                    userDecision = Console.ReadLine().ToUpper();
                    if (userDecision != "YES" && userDecision != "NO")
                    {
                        Console.WriteLine($"Your Decision {userDecision} is not valid");
                    }
                } while (userDecision != "YES" && userDecision != "NO");
            } while (userDecision == "YES");
        }

        public void IteratingArrayByLoops()
        {
            int[] numberArray = new int[5] { 10,29,34,12,8};
            
            //by using for loop
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }

            //by using while loop
            int j = 0;
            while (j < numberArray.Length)
            {
                Console.WriteLine(numberArray[j]);
                j++;
            }

            //by using foreach
            foreach (int k in numberArray)
            {
                Console.WriteLine(k);
            }
        }

        public void PrintTables()
        {
            Console.WriteLine("Enter a number to generate its multiplication table:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication Table for {number}:");
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }

        public void IterateStringArray()
        {
            string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            Console.WriteLine("List of Fruits:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }

        public void IterateLists()
        {
            List<string> names = new List<string> { "Bob", "Alice", "James", "Marry", "John" };
        
            Console.WriteLine("List of Names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public void BreakAndContinueExample()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Processing numbers:");

            foreach (int number in numbers)
            {
                if (number == 5)
                {
                    Console.WriteLine("Reached number 5, exiting the loop.");
                    break; 
                }

                if (number % 2 == 0)
                {
                    Console.WriteLine($"Skipping number {number} as it is even.");
                    continue;  
                }
                Console.WriteLine($"Processing number: {number}");
            }
            Console.WriteLine("Finished processing numbers.");
        }
    }
}
