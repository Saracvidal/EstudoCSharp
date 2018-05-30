using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average1
{
    class Average1
    {
        static void Main(string[] args)
        {
            int total = 0,
                gradeCounter = 1,
                gradeValue,
                average;

            while(gradeCounter <= 10)
            {
                Console.Write("Enter integer grade: ");

                gradeValue = Int32.Parse(Console.ReadLine());

                total += gradeValue;

                gradeCounter++;
            }

            average = total / 10;

            Console.WriteLine("\nClass average is {0}", average);
        }
    }
}
