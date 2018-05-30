using System;

namespace ThisTest
{
    class ThisTest
    {
        static void Main(string[] args)
        {
            Time4 time = new Time4(12, 30, 19);
            Console.WriteLine(time.BuildString());
        }
    }
}
