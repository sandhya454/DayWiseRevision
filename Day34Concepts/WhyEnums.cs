using System;

namespace Day34Concepts.WhyEnums
{
    public class WithoutEnums
    {
        public void PrintCustomer()
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                Name = "Mark",
                Gender = 0
            };
            customers[1] = new Customer
            {
                Name = "Mary",
                Gender = 1
            };
            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = 2
            };
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Name:{customer.Name} and Gender:{GetGender(customer.Gender)}");
            }
        }

        public string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
}
