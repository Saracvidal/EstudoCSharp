using System;

namespace Time1
{
    class TimeTest1
    {
        static void Main(string[] args)
        {
            /*Time1 time = new Time1();
            string output;
            output = "\nInitial universal time: " + time.ToUniversalString() + "\tInitial standard time: " + time.ToStandardString();

            time.SetTime(13,27,6);
            output += "\nUniversal after SetTime: " + time.ToUniversalString() + "\tStandard after SetTime: " + time.ToStandardString();

            time.SetTime(99, 99, 99);
            output += "\nAfter attempting invalid settings\nUniversal Time: " + time.ToUniversalString() + "\tStandard Time: " + time.ToStandardString();

            Console.WriteLine(output);*/

            /*Time2 time1, time2, time3, time4, time5, time6;

            time1 = new Time2();
            time2 = new Time2(2);
            time3 = new Time2(21, 34);
            time4 = new Time2(12, 25, 42);
            time5 = new Time2(27, 74, 99);
            time6 = new Time2(time4);

            String output = "Constructed with: " + 
                "\ntime1: all arguments defaulted" +
                "\n\t" + time1.ToUniversalString() + 
                "\n\t" + time1.ToStandardString();

            output += "\ntime2: hour specified; minute and " +
                "second defaulted" + 
                "\n\t" + time2.ToUniversalString() +
                "\n\t" + time2.ToStandardString();

            output += "\ntime3: hour and minute specified; " +
                "second defaulted" +
                "\n\t" + time3.ToUniversalString() +
                "\n\t" + time3.ToStandardString();

            output += "\ntime4: hour, minute, and second specified" +
                "\n\t" + time4.ToUniversalString() + 
                "\n\t" + time4.ToStandardString();

            output += "\ntime5: all invalid values specified" + 
                "\n\t" + time5.ToUniversalString() + 
                "\n\t" + time5.ToStandardString();

            output += "\ntime6: Time2 object time4 specified" + 
                "\n\t" + time6.ToUniversalString() +
                "\n\t" + time6.ToStandardString();

            Console.WriteLine(output);*/


            Time3 time = new Time3();
            string output;  

            Console.WriteLine("Hour: " + time.Hour);
            Console.WriteLine("Minute: " + time.Minute);
            Console.WriteLine("Second: " + time.Second);

            output = "\nUniversal time: " + time.ToUniversalString() + "\tStandard time: " + time.ToStandardString();

            Console.WriteLine("Set the new values: ");
            Console.WriteLine("Hour: ");
            time.Hour = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Minute: ");
            time.Minute = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Second: ");
            time.Second = Int32.Parse(Console.ReadLine());

            output += "\nNew Universal time: " + time.ToUniversalString() + "\tNew Standard time: " + time.ToStandardString();

            Console.WriteLine(output);
        }
    }
}
