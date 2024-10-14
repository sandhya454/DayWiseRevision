using System;
using System.Text;

namespace Day33Concepts.OverrideToString
{
    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override string ToString()
        {
            return $"{this.firstName} , {this.lastName}";
        }
    }

    public class OverrideToStringMethods
    {
        public void OverrideToStringExample()
        {
            Customer customer = new Customer();
            customer.firstName = "Savar";
            customer.lastName = "Technologies";

            Console.WriteLine(customer.ToString());
            Console.WriteLine(Convert.ToString(customer));
        }

        public void ConvertToStringExample()
        {
            Customer customer = null;
            Console.WriteLine(Convert.ToString(customer));
            //Console.WriteLine(C1.ToString());
        }
    }

    public class Strings
    {
        public void SysytemStringExample()
        {
            string userString = "C#";
            userString += "Video";
            userString += "Tutorail";
            userString += "for";
            userString += "Beginers";
            Console.WriteLine(userString);
        }

        public void StringBuilderExample()
        {
            StringBuilder userString = new StringBuilder("C#");
            userString.Append("Video");
            userString.Append("Tutorial");
            userString.Append("for");
            userString.Append("Beginers");
            Console.WriteLine(userString);
        }
    }
}
