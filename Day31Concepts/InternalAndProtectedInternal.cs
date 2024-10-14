using System;
using AssemblyOne;

namespace Day31Concepts.InternalAndProtectedInternal
{
    public class EmployeeId
    {
        internal int employeeId;
    }

    public class Employee
    {
        public void PritnId()
        {
            EmployeeId id = new EmployeeId();
            id.employeeId = 10;
            Console.WriteLine(id.employeeId);
        }
    }

    public class EmployeeName : AssemblyOneClassI
    {
        public void PrintName()
        {
            EmployeeName employeeName = new EmployeeName();
            employeeName.name = "Manohar";
            Console.WriteLine(employeeName.name);
        }
    }
}
