﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time3
{
    public class Time3
    {
        private int hour;
        private int minute;
        private int second;
    }

    public Time3()
    {
        SetTime(0, 0, 0);
    }

    public Time3(int hour)
    {
        SetTime(hour, 0, 0);
    }

    public Time3(int hour, int minute)
    {
        SetTime(hour, minute, 0);
    }

    public Time3(int hour, int minute, int second)
    {
        SetTime(hour, minute, second);
    }

    public Time3(Time3 time)
    {
        SetTime(time.Hour, time.Minute, time.Second);
    }

    public void SetTime(int hourValue, int minuteValue, int secondValue)
    {
        Hour = hourValue;
        Minute = minuteValue;
        Second = secondValue;
    }

    public int Hour
    {
        get
        {
            return hour;
        }

        set
        {
            hour = ((value >= 0 && value < 24) ? value : 0);
        }
    }

    public int Minute
    {
        get
        {
            return minute;
        }

        set
        {
            minute = ((value >= 0 && value < 60) ? value : 0);
        }
    }

    public int Second
    {
        get
        {
            return second;
        }

        set
        {
            second = ((value >= 0 && value < 60) ? value : 0);
        }
    }

    public string ToUniversalString()
    {
        return String.Format("{0}:{}:{}");
    }
}
