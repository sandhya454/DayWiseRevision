using Day35Concepts.Customers;
using Day35Concepts.CustomerTestData;
using System;
using System.Collections.Generic;

namespace Day35Concepts.ListClassRanges
{
    public class RangeMethods
    {
        public void AddRangeMethod()
        {
            CustomerData customerObject = new CustomerData();

            List<Customer> retailCustomers = customerObject.GetRetailCustomers();
            List<Customer> corporateCustomer = customerObject.GetCorporateCustomer();

            retailCustomers.AddRange(corporateCustomer);
            foreach (Customer customer in retailCustomers)
            {
                Console.WriteLine($"Id:{customer.Id},Name:{customer.Name},Salary:{customer.Salary},Type:{customer.Type}");
            }
        }

        public void GetRangeMethod()
        {
            CustomerData customerObject = new CustomerData();

            List<Customer> retailCustomers = customerObject.GetRetailCustomers();
            List<Customer> corporateCustomer = customerObject.GetCorporateCustomer();

            retailCustomers.AddRange(corporateCustomer);
            List<Customer> customers = retailCustomers.GetRange(2, 3);

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Id:{customer.Id},Name:{customer.Name},Salary:{customer.Salary},Type:{customer.Type}");
            }
        }

        public void InsertRangeMethod()
        {
            CustomerData customerObject = new CustomerData();
            List<Customer> retailCustomers = customerObject.GetRetailCustomers();
            List<Customer> corporateCustomer = customerObject.GetCorporateCustomer();

            retailCustomers.InsertRange(2, corporateCustomer);
            foreach (Customer customer in retailCustomers)
            {
                Console.WriteLine($"Id:{customer.Id},Name:{customer.Name},Salary:{customer.Salary},Type:{customer.Type}");
            }
        }

        public void RemoveRangeMethod()
        {
            CustomerData customerObject = new CustomerData();
            List<Customer> retailCustomers = customerObject.GetRetailCustomers();
            List<Customer> corporateCustomer = customerObject.GetCorporateCustomer();

            retailCustomers.InsertRange(2, corporateCustomer);
            retailCustomers.RemoveRange(3, 2);

            foreach (Customer customer in retailCustomers)
            {
                Console.WriteLine($"Id:{customer.Id},Name:{customer.Name},Salary:{customer.Salary},Type:{customer.Type}");
            }
        }

        public void ManagingEmployeeData()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Department = "HR" },
                new Employee { Id = 2, Name = "Bob", Department = "IT" },
                new Employee { Id = 3, Name = "Charlie", Department = "Finance" },
                new Employee { Id = 4, Name = "David", Department = "Marketing" },
                new Employee { Id = 5, Name = "Eve", Department = "IT" }
            };

            Console.WriteLine("Initial Employees List:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            //GetRange: Retrieve a subset of employees
            Console.WriteLine("\nGetting a range of employees (index 1 to 3):");
            List<Employee> subsetEmployees = employees.GetRange(1, 3);
            foreach (var employee in subsetEmployees)
            {
                Console.WriteLine(employee);
            }

            //AddRange: Adding a range of new employees
            List<Employee> newEmployees = new List<Employee>
            {
                new Employee { Id = 6, Name = "Frank", Department = "Finance" },
                new Employee { Id = 7, Name = "Grace", Department = "HR" }
            };
            Console.WriteLine("\nAdding new employees:");
            employees.AddRange(newEmployees);

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            //RemoveRange: Removing a range of employees
            Console.WriteLine("\nRemoving a range of employees (index 2 to 3):");
            employees.RemoveRange(2, 2);
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            //InsertRange: Inserting a range of employees at a specific position
            List<Employee> temporaryEmployees = new List<Employee>
            {
                new Employee { Id = 8, Name = "Hannah", Department = "Sales" },
                new Employee { Id = 9, Name = "Ivy", Department = "IT" }
            };
            Console.WriteLine("\nInserting new employees at index 2:");
            employees.InsertRange(2, temporaryEmployees);
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Department: {Department}";
        }
    }
}
