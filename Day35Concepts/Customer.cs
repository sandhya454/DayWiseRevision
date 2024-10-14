using System;
using System.Collections.Generic;

namespace Day35Concepts.Customers
{
    public class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type {  get; set; }
        public int CompareTo(Customer other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }

    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    public class SortByType : IComparer<Customer> 
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Type.CompareTo(y.Type);
        }
    }
}
