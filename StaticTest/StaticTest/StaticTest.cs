using System;

namespace StaticTest
{
    class StaticTest
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Employees before sntantiation: " + Employee.Count + "\n");

            Employee employee1 = new Employee("Suzan", "Baker");
            Employee employee2 = new Employee("Bob", "Jhones");

            Console.WriteLine("Employees after sntantiation: " + "Employee.Count:" + Employee.Count + "\n");

            Console.WriteLine("Employee 1: " + employee1.FirstName + " " + employee1.LastName + "\n" + "Employee 2: " + employee2.FirstName + " " + employee2.LastName + "\n");

            employee1 = null;
            employee2 = null;

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            Console.WriteLine("\nEmployees after garbage collection: " + Employee.Count);
        }
    }
}
