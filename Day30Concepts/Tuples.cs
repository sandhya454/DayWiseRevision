using System;

namespace Day30Concepts.Tuples
{
    public class Examples
    {
        public void TupleDeclarationExample()
        {
            Tuple<int, string, double> obj = new Tuple<int, string, double>(121, "Mark", 30000);
            var emp = Tuple.Create(121, "Marry", 30000);

            var employee = GetEmployee();
            Console.WriteLine($"emp id:{employee.Item1} Name:{employee.Item2} and Salary:{employee.Item3}");

            var employees = GetEmployees();
            Console.WriteLine($"emp id:{employees.Item1} Name:{employees.Item2} and Salary:{employees.Item3}");

            var employeeDetails = GetEmployeeDetails();
            Console.WriteLine($"emp id:{employeeDetails.empId} Name:{employeeDetails.empName} and Salary:{employeeDetails.empSalary}");

            var result = PerformOperations(5, 3);
            Console.WriteLine($"Sum: {result.sum}, Difference: {result.difference}");
        }

        public Tuple<int, string, double> GetEmployee()
        {
            return new Tuple<int, string, double>(194, "Johnson", 98000);
        }

        public (int, string, double) GetEmployees()
        {
            return (571, "Maonica", 89000);
        }

        public (int empId, string empName, double empSalary) GetEmployeeDetails()
        {
            var emp = (eId: 0, eName: string.Empty, eSalary: 0.0);
            emp.eId = 424;
            emp.eName = "Wilson";
            emp.eSalary = 390000;
            return (emp);
        }

        public  (int sum, int difference) PerformOperations(int a, int b)
        {
            int sum = a + b;
            int difference = a - b;
            return (sum, difference);
        }
    }
}
