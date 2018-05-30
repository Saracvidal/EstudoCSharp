using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;

            c = 5;
            Console.WriteLine(c);
            Console.WriteLine(c++);
            Console.WriteLine(c);

            c = 5;
            Console.WriteLine(c);
            Console.WriteLine(++c);
            Console.WriteLine(c);

        }
    }
}
