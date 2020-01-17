using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblems
{
    // https://www.hackerrank.com/challenges/time-conversion/problem
    public static class TimeConversion
    {
        public static string timeConversion(string s)
        {
            // 07:05:45PM output 19:05:45
            // 12:00:00AM output 00:00:00
            // 08:43:00AM output 08:43:00
            // 12:00:00PM output 12:00:00

            int hour = Convert.ToInt32(s.Substring(0, 2));
            string minutes = s.Substring(3, 2);
            string seconds = s.Substring(6, 2);

            string period = s.Substring(8, 2);

            if (period == "AM" && hour == 12)
            {
                return $"00:{minutes}:{seconds}";
            }
            else if (period == "PM" && hour < 12)
            {
                return $"{hour + 12}:{minutes}:{seconds}";
            }
            else
            {
                var stringHour = hour < 10 ? hour.ToString().PadLeft(2, '0') : hour.ToString();
                return $"{stringHour}:{minutes}:{seconds}";
            }
        }
    }
}
