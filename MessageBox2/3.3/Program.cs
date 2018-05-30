using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,
                b,
                c;

            MessageBox.Show("Enter two numbers");
            Console.Write("Number 1: ");
            a = Int32.Parse(Console.ReadLine());

            Console.Write("Number 2: ");
            b = Int32.Parse(Console.ReadLine());

            c = a * b;//returns the product of variables a and b to c

            MessageBox.Show("The product of " + a + " * " + b + " = " + c); 
        }
    }
}
