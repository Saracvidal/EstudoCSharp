using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditional AND (&&) " +
                "\nfalse && false: " + (false && false) +
                "\ntrue && false: " + (true && false) +
                "\nfalse && true: " + (false && true) +
                "\ntrue && true: " + (true && true));

            Console.WriteLine("\nConditional OR (||) " +
                "\nfalse || false: " + (false || false) +
                "\ntrue || false: " + (true || false) +
                "\nfalse || true: " + (false || true) +
                "\ntrue || true: " + (true || true));

            Console.WriteLine("\nLogical OR (&) " +
                "\nfalse & false: " + (false & false) +
                "\ntrue & false: " + (true & false) +
                "\nfalse & true: " + (false & true) +
                "\ntrue & true: " + (true & true));

            Console.WriteLine("\nLogical OR (|) " +
                "\nfalse | false: " + (false | false) +
                "\ntrue | false: " + (true | false) +
                "\nfalse | true: " + (false | true) +
                "\ntrue | true: " + (true | true));

            Console.WriteLine("\nLogical eclusive OR (^) " +
                "\nfalse ^ false: " + (false ^ false) +
                "\ntrue ^ false: " + (true ^ false) +
                "\nfalse ^ true: " + (false ^ true) +
                "\ntrue ^ true: " + (true ^ true));

            Console.WriteLine("\nLogical NOT (!) " +
                "\n! true: " + (!true) +
                "\n! false: " + (!false));
        }
    }
}
