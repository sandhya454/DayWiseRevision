using System;
using System.Collections.Generic;

namespace Day34Concepts.EnumsExamplesAndAdvantages
{
    public class EnumsExamples
    {
        public void PrintCustomers()
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                Name = "Mark",
                Gender = Gender.Male
            };
            customers[1] = new Customer
            {
                Name = "Marry",
                Gender = Gender.Female
            };
            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = Gender.Unknown
            };
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Name:{customer.Name} and Gender:{GetGender(customer.Gender)}");
            }
        }

        public string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }

        public void EnumsWithExplicitWithValues()
        {
            HttpStatusCode statusCode = HttpStatusCode.NotFound;
            Console.WriteLine($"Status Code: {(int)statusCode} ({statusCode})");
        }

        public void EnumsWithClassExample()
        {
            Employee employee = new Employee("Alice", EmployeeRole.Developer, 80000);
            Console.WriteLine($"{employee.Name} is a {employee.Role} with a salary of {employee.Salary}." +
                $" Job: {GetJobDescription(employee.Role)}");
        }

        public string GetJobDescription(EmployeeRole role)
        {
            switch (role)
            {
                case EmployeeRole.Manager:
                    return "Manages teams and projects.";
                case EmployeeRole.Developer:
                    return "Develops software.";
                case EmployeeRole.Designer:
                    return "Designs UI/UX.";
                case EmployeeRole.Tester:
                    return "Tests the software.";
                default:
                    return "Unknown role.";
            }
        }

        public void EnumWithDictionaryExample()
        {
            var carCatalog = new Dictionary<CarBrand, Car>
        {
            { CarBrand.Tesla, new Car("Model S", 1020) },
            { CarBrand.BMW, new Car("M5", 600) },
            { CarBrand.Audi, new Car("RS7", 591) },
            { CarBrand.Toyota, new Car("Supra", 382) }
        };
            CarBrand selectedBrand = CarBrand.Audi;
            Console.WriteLine($"{selectedBrand}: {carCatalog[selectedBrand]}");

            foreach (var car in carCatalog)
            {
                Console.WriteLine($"{car}");
            }
        }

        public void EnumWithStructExample()
        {
            Weapon sword = new Weapon(WeaponType.Sword, 50, 1.5f);
            Weapon bow = new Weapon(WeaponType.Bow, 30, 15f);

            Console.WriteLine(sword);
            Console.WriteLine(bow);
        }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    public enum HttpStatusCode
    {
        OK = 200,
        Created = 201,
        Accepted = 202,
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404,
        InternalServerError = 500
    }

    public enum EmployeeRole
    {
        Manager,
        Developer,
        Designer,
        Tester
    }

    public enum CarBrand
    {
        Tesla,
        BMW,
        Audi,
        Toyota
    }

   public enum WeaponType
    {
        Sword,
        Bow,
        Staff,
        Dagger
    }

    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }

    class Employee
    {
        public string Name { get; set; }
        public EmployeeRole Role { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, EmployeeRole role, decimal salary)
        {
            Name = name;
            Role = role;
            Salary = salary;
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public int HorsePower { get; set; }

        public Car(string model, int horsePower)
        {
            Model = model;
            HorsePower = horsePower;
        }

        public override string ToString() => $"{Model} with {HorsePower} HP";
    }

    public struct Weapon
    {
        public WeaponType Type { get; }
        public int Damage { get; }
        public float Range { get; }

        public Weapon(WeaponType type, int damage, float range)
        {
            Type = type;
            Damage = damage;
            Range = range;
        }

        public override string ToString()
        {
            return $"{Type}: Damage = {Damage}, Range = {Range} meters";
        }
    }
}
