using System;

namespace UsingConstAndReadonly
{
    public class Constants
    {
        public const double PI = 3.14159;
        public readonly int radius;

        public Constants(int radius)
        {
            this.radius = radius;
        }
    }

    public class UsingConstAndReadonly
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Constants constantValues = new Constants(random.Next(1, 20));

            Console.WriteLine("Radius: " + constantValues.radius + "\nCircumference: " + constantValues.radius * Constants.PI * 2);
        }
    }
}
