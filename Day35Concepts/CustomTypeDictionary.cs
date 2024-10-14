using System;
using System.Collections.Generic;

namespace Day35Concepts.CustomTypeDictionary
{
    public class CustomDictionaryExample
    {
        public void CustomTypeDicitionaryExample()
        {
            var ambassadors = new Dictionary<CountryCode, Ambassador>();

            Ambassador england = new Ambassador
            {
                CountryCode = new CountryCode("eng"),
                Name = "John",
                Age = 44
            };
            Ambassador australia = new Ambassador
            {
                CountryCode = new CountryCode("aus"),
                Name = "Mark",
                Age = 33
            };
            ambassadors.Add(england.CountryCode, england);
            ambassadors.Add(australia.CountryCode, australia);

            Console.WriteLine("Enter Country Code eng or aus:");
            var code = Console.ReadLine();

            if (ambassadors.TryGetValue(new CountryCode(code), out Ambassador ambassdor))
            {
                Console.WriteLine($"The ambassdor is {ambassdor.Name} and age is {ambassdor.Age}");
            }
            else
            {
                Console.WriteLine("The ambassdor with given Code is not exsits in the dictionary");
            }
        }

        public void DictionaryExample()
        {
            Dictionary<Product, ProductDetails> productDictionary = new Dictionary<Product, ProductDetails>();

            productDictionary.Add(new Product { Id = 1, Name = "Laptop" }, new ProductDetails { Price = 999.99m, Stock = 10 });
            productDictionary.Add(new Product { Id = 2, Name = "Smartphone" }, new ProductDetails { Price = 699.99m, Stock = 50 });

            // Iterating over the dictionary
            foreach (var entry in productDictionary)
            {
                Console.WriteLine($"{entry.Key} => {entry.Value}");
            }
        }
    }

    public class CountryCode
    {
        public string Code { get; }

        public CountryCode(string code)
        {
            Code = code;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is CountryCode)) return false;
            return StringComparer.OrdinalIgnoreCase.Equals(this.Code, ((CountryCode)obj).Code);
        }

        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(this.Code);
        }
    }

    public class Ambassador
    {
        public CountryCode CountryCode { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Product ID: {Id}, Name: {Name}";
        }
    }

    public class ProductDetails
    {
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return $"Price: {Price}, Stock: {Stock}";
        }
    }
}
