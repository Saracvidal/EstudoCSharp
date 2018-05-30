using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            string  firstNumber,
                    secondNumber;

            int number1,
                number2,
                sum;

            Console.Write("Please, enter the first integer:");
            firstNumber = Console.ReadLine();

            Console.Write("Please, enter the second number:");
            secondNumber = Console.ReadLine();

            number1 = Int32.Parse(firstNumber);
            number2 = Int32.Parse(secondNumber);


            sum = number1 + number2;

            Console.WriteLine("\nThe numbers entered are {0} and {1}.", number1, number2);
            Console.WriteLine("\nThe sum is {0}. ", sum);
        }
    }
}
