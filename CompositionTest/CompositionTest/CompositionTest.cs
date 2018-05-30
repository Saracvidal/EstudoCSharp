using System;

namespace CompositionTest
{
    class CompositionTest
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Sara", "Vidal de Souza", 11, 01, 1988, 05, 01, 2018);

            Console.WriteLine(employee.ToEmployeeString());
        }
    }
}
