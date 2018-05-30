using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int number0 = 0,
                number1 = 1,
                number2 = 2,
                number3 = 3,
                number4 = 4,
                number5 = 5,
                number6 = 6,
                number7 = 7,
                number8 = 8,
                number9 = 9,
                number10 = 10,
                square0,
                square1,
                square2,
                square3,
                square4,
                square5,
                square6,
                square7,
                square8,
                square9,
                square10,
                cube0,
                cube1,
                cube2,
                cube3,
                cube4,
                cube5,
                cube6,
                cube7,
                cube8,
                cube9,
                cube10;

            square0 = number0 * number0;
            square1 = number1 * number1;
            square2 = number2 * number2;
            square3 = number3 * number3;
            square4 = number4 * number4;
            square5 = number5 * number5;
            square6 = number6 * number6;
            square7 = number7 * number7;
            square8 = number8 * number8;
            square9 = number9 * number9;
            square10 = number10 * number10;

            cube0 = number0 * square0;
            cube1 = number1 * square1;
            cube2 = number2 * square2;
            cube3 = number3 * square3;
            cube4 = number4 * square4;
            cube5 = number5 * square5;
            cube6 = number6 * square6;
            cube7 = number7 * square7;
            cube8 = number8 * square8;
            cube9 = number9 * square9;
            cube10 = number10 * square10;

            Console.WriteLine("Number\tSquare\tCube\n");
            Console.WriteLine(number0 + "\t" + square0 + "\t" + cube0);
            Console.WriteLine(number1 + "\t" + square1 + "\t" + cube1);
            Console.WriteLine(number2 + "\t" + square2 + "\t" + cube2);
            Console.WriteLine(number3 + "\t" + square3 + "\t" + cube3);
            Console.WriteLine(number4 + "\t" + square4 + "\t" + cube4);
            Console.WriteLine(number5 + "\t" + square5 + "\t" + cube5);
            Console.WriteLine(number6 + "\t" + square6 + "\t" + cube6);
            Console.WriteLine(number7 + "\t" + square7 + "\t" + cube7);
            Console.WriteLine(number8 + "\t" + square8 + "\t" + cube8);
            Console.WriteLine(number9 + "\t" + square9 + "\t" + cube9);
            Console.WriteLine(number10 + "\t" + square10 + "\t" + cube10);
        }
    }
}
