using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            int passes = 0,
                failures = 0,
                student = 1,
                contTestA = 1,
                contTestB = 1,
                result;

            while (student <= 10)
            {
                Console.Write("Enter result (1=pass, 2=fail): ");
                result = Int32.Parse(Console.ReadLine());

                if (result == 1)
                    passes += 1;
                else
                    failures += 1;

                student++;
                ++contTestA;
                contTestB++;
            }

            Console.WriteLine();
            Console.WriteLine("Passed: {0}\nFailed: {1}\n", passes, failures);
            Console.WriteLine("Contador de teste ++ A: {0} \n", contTestA);
            Console.WriteLine("Contador de teste ++ B: {0} \n", contTestB);

            if (passes > 8)
                Console.WriteLine("Raise Tuiton\n");
        }
    }
}
