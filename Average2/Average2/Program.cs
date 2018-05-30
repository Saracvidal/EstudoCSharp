using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total,
                gradeCounter,
                gradeValue;

            double average;

            total = 0;
            gradeCounter = 1;

            Console.WriteLine("Enter integer grade, -1 to  QUIT: ");
            gradeValue = Int32.Parse(Console.ReadLine());

            while(gradeValue != -1)
            {
                total += gradeValue;
                gradeCounter += 1;

                Console.WriteLine("Enter integer grade, -1 to  QUIT: ");
                gradeValue = Int32.Parse(Console.ReadLine());

            }

            if (gradeCounter != 0)
            {
                average = (double)total / gradeCounter;

                Console.WriteLine("\nClass average is {0}", average);
            }
            if (gradeCounter == 0)
            {
                Console.WriteLine("No grades were entered.");
            }
        }
    }
}
