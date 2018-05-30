using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1,
                number2;

            Console.Write("Enter the first number: ");
            number1 = Int32.Parse(Console.ReadLine());

            Console.Write("\nEnter the second number: ");
            number2 = Int32.Parse(Console.ReadLine());

            if ((number1 % number2) == 0)
                Console.WriteLine(number1 + " is multiple of " + number2);
            else
                Console.WriteLine(number1 + " is NOT multiple of " + number2);
        }
    }
}
