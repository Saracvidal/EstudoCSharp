using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1,
                number2;

            Console.Write("Please, enter the first number: ");
            number1 = Int32.Parse(Console.ReadLine());

            Console.Write("Please, enter the second number: ");
            number2 = Int32.Parse(Console.ReadLine());

            if (number1 == number2)
                Console.WriteLine(number1 + " == " + number2);

            if (number1 != number2)
                Console.WriteLine(number1 + " != " + number2);

            if (number1 < number2)
                Console.WriteLine(number1 + " < " + number2);

            if (number1 > number2)
                Console.WriteLine(number1 + " > " + number2);

            if (number1 <= number2)
                Console.WriteLine(number1 + " <= " + number2);

            if (number1 >= number2)
                Console.WriteLine(number1 + " >= " + number2);
        }
    }
}
