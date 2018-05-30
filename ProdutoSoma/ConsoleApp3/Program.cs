using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1,
                numero2,
                soma,
                produto,
                diferenca,
                quociente;

            Console.WriteLine("Entre com o primeiro numero: ");
            numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo numero: ");
            numero2 = Int32.Parse(Console.ReadLine());

            soma = numero1 + numero2;
            produto = numero1 * numero2;
            quociente = numero1 / numero2;
            diferenca = numero1 - numero2;

            Console.WriteLine("{0} + {1} = {2}\n", numero1, numero2, soma);
            Console.WriteLine("{0} * {1} = {2}\n", numero1, numero2, produto);
            Console.WriteLine("{0} - {1} = {2}\n", numero1, numero2, diferenca);
            Console.WriteLine(numero1 + " / " + numero2 + " = " + quociente);
        }
    }
}
