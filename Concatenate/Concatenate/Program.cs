using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName,
                   secondName;

            Console.WriteLine("Enter the First Name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter the Second Name: ");
            secondName = Console.ReadLine();

            Console.WriteLine("The full name is " + firstName + " " + secondName);

        }
    }
}
