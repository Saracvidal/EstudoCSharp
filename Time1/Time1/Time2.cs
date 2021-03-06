﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Time1
{
    public class Time2
    {
        private int hour;
        private int minute;
        private int second;

        public Time2()
        {
            SetTime(0, 0, 0);
        }

        public Time2(int hour)
        {
            SetTime(hour, 0, 0);
        }

        public Time2(int hour, int minute)
        {
            SetTime(hour, minute, 0);
        }

        public Time2(int hour, int minute, int second)
        {
            SetTime(hour, minute, second);
        }

        public Time2(Time2 time)
        {
            SetTime(time.hour, time.minute, time.second);
        }

        public void SetTime(int hourValue, int minuteValue, int secondValue)
        {
            hour = (hourValue >= 0 && hourValue < 24) ? hourValue : 0;
            minute = (minuteValue >= 0 && minuteValue < 60) ? minuteValue : 0;
            second = (secondValue >= 0 && secondValue < 60) ? secondValue : 0;
        }

        public string ToUniversalString()
        {
            return String.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
        }

        public string ToStandardString()
        {
            return String.Format("{0:D2}:{1:D2}:{2:D2} {3}", ((hour == 12 || hour == 0) ? 12 : hour % 12), minute, second, (hour < 12 ? "AM" : "PM"));
        }
    }
}
