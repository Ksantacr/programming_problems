using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Question06
    {
        public float angles(string[] times)
        {
            float angle = 0;

            foreach (var time in times)
            {
                if (isPatternCorrect(time))
                {
                    int hours = Convert.ToInt32(time.Split(':')[0]);
                    int minutes = Convert.ToInt32(time.Split(':')[1]);

                    if (hours >= 0 && hours <= 23 && minutes >= 00 && minutes <= 59)
                    {
                        if (hours > 12)
                        {
                            hours -= 12;
                        }

                        float hourAngle = (float)(0.5 * (hours * 60 + minutes));
                        float minuteAngle = (6 * minutes);
                        angle += Math.Abs(minuteAngle - hourAngle);

                        // smaller angle of two possible angles 
                        angle = Math.Min(360 - angle, angle);
                    }
                }
                else
                {
                    angle -= 100;
                }
            }

            return angle;
        }

        private bool isPatternCorrect(string time)
        {
            string pattern = "\\d{1,2}:\\d{2}";
            if (!Regex.IsMatch(time, pattern))
                return false;

            return true;

        }
    }
}
