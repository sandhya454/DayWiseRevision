using System;

namespace Day30Concepts.ConditionalStatements
{
    public class Statements
    {
        public void IfStatementExample()
        {
            Console.WriteLine("Enter a number");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 1)
            {
                Console.WriteLine("User NUmber is One");
            }
            if (userNumber == 2)
            {
                Console.WriteLine("User Number is Two");
            }
            if (userNumber == 3)
            {
                Console.WriteLine("User Number is Three");
            }
            if (userNumber != 1 && userNumber != 2 && userNumber != 3)
            {
                Console.WriteLine("User Number is not between 1 and 3");
            }
        }

        public void IfElseStatementExample()
        {
            Console.WriteLine("Enter a number");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 1)
            {
                Console.WriteLine("User NUmber is One");
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("User Number is Two");
            }
            else if (userNumber == 3)
            {
                Console.WriteLine("User Number is Three");
            }
            else
            {
                Console.WriteLine("User Number is not between 1 and 3");
            }
        }

        public void CheckingTemperature()
        {
            Console.WriteLine("Enter the current Temperature in Celsius:");
            int temperature = int.Parse(Console.ReadLine());

            if (temperature >= 30)
            {
                Console.WriteLine("It's hot outside. Stay hydrated and wear light clothes.");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("The weather is warm. A perfect day for outdoor activities.");
            }
            else if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("It's a bit chilly. Wear a light jacket.");
            }
            else if (temperature >= 0 && temperature < 10)
            {
                Console.WriteLine("It's cold. Make sure to bundle up.");
            }
            else
            {
                Console.WriteLine("It's freezing! Stay warm indoors and avoid going outside.");
            }
        }

        public void SwitchStatementExample()
        {
            Console.WriteLine("Enter a number");
            int userNumber = int.Parse(Console.ReadLine());

            switch (userNumber)
            {
                case 10:
                    Console.WriteLine("Your number is 10");
                    break;
                case 20:
                    Console.WriteLine("Your number is 20");
                    break;
                case 30:
                    Console.WriteLine("Your Number is 30");
                    break;
                default:
                    Console.WriteLine("Your number is not 10,20 & 30");
                    break;
            }
        }

        public void SelectingVechicle()
        {
            Console.WriteLine("Enter a vehicle type (car, bike, bus, truck):");
            string vehicleType = Console.ReadLine();

            switch (vehicleType.ToLower())  
            {
                case "car":
                    Console.WriteLine("You selected a car. Cars are suitable for small families.");
                    break;
                case "bike":
                    Console.WriteLine("You selected a bike. Bikes are fast and fuel-efficient for individuals.");
                    break;
                case "bus":
                    Console.WriteLine("You selected a bus. Buses can carry many passengers.");
                    break;
                case "truck":
                    Console.WriteLine("You selected a truck. Trucks are used for transporting goods.");
                    break;
                default:
                    Console.WriteLine("Invalid vehicle type. Please enter a valid vehicle type (car, bike, bus, truck).");
                    break;
            }
        }

        public void CoffeePurchase()
        {
            int totalCost = 0;
        Start:
            Console.WriteLine("Please Enter your Coffee Size :: 1-small 2-medium 3- large");
            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
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
                    Console.WriteLine($"Your Choice {userChoice} is Invalid");
                    goto Start;
            }

        Decide:
            Console.WriteLine("Do you Want to Buy Another Coffee Enter  Yes or No");
            string userDecision = Console.ReadLine();
            switch (userDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine($"Your Decision {userDecision} is Invalid");
                    goto Decide;
            }
            Console.WriteLine("Thankyou for Shopping With Us");
            Console.WriteLine($"Your Bill is {totalCost}$");
        }
    }
}
