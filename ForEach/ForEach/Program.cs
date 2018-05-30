using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] gradeArray = { { 77, 68, 86, 73 }, { 88, 87, 89, 81 }, { 70, 90, 86, 81 } };

            int lowGrade = 100;

            foreach(var grade in gradeArray)
            {
                if (grade < lowGrade)
                    lowGrade = grade;
            }

            Console.WriteLine("The minimum grade is: " + lowGrade);
        }
    }
}
