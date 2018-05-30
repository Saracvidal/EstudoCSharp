using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius,
                    diameter,
                    circunference,
                    area;

            Console.Write("Enter with Radius of the circle: ");
            radius = double.Parse(Console.ReadLine());

            diameter = 2 * radius;
            circunference = 2 * (Math.PI) * radius;
            area = Math.PI * (radius * radius);

            Console.Write("Circle information:\n");
            Console.WriteLine("Diameter: " + diameter);
            Console.WriteLine("Circunference: " + circunference);
            Console.WriteLine("Area: " + area);
        }
    }
}
