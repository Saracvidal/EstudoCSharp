﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ThisTest
{
    public class Time4
    {
        private int hour;
        private int minute;
        private int second;

        public Time4(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public string BuildString()
        {
            return "this.ToStandardString(): " + this.ToStandardString();
        }

        public string ToStandardString()
        {
            return String.Format("{0}:{1:D2}:{2:D2} {3}", ((this.hour == 12 || this.hour == 0) ? 12 : this.hour % 12), this.minute, this.second, (this.hour < 12 ? "AM" : "PM"));
        }
    }
}
