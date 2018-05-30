using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1,
                n10,
                n100,
                n1000;

            Console.WriteLine("N\t10*N\t100*N\t1000*N\n");

            while (n <= 5)
            {
                n10 = 10 * n;
                n100 = 100 * n;
                n1000 = 1000 * n;

                Console.WriteLine(n + "\t" + n10 + "\t" + n100 + "\t" + n1000);
                n++;
            }
        }
    }
}
