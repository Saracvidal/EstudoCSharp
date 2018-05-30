using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTest
{
    public class Date
    {
        private int month;
        private int day;
        private int year;

        public Date(int theMonth, int theDay, int theYear)
        {
            if (theMonth >= 0 && theMonth <= 12)
                month = theMonth;
            else
            {
                month = 1;
                Console.WriteLine("Month {0} invalid. Set to month 1.", theMonth);
            }

            year = theYear;
            day = CheckDay(theDay);
        }

        private int CheckDay(int testDay)
        {
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (testDay > 0 && testDay <= daysPerMonth[month])
                return testDay;

            Console.WriteLine("Day {0} invalid. Set to day 1.");

            return 1;
        }

        public string ToDateString()
        {
            return month + "/" + day + "/" + year;
        }
    }
}
