using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class GradingStudents
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                int result = Math.Abs(nextMultipleOfFive(grades[i]) - grades[i]);
                if (result < 3 && grades[i] >= 38)
                {
                    grades[i] = nextMultipleOfFive(grades[i]);
                }
            }
            return grades;
        }
        private static int nextMultipleOfFive(int number)
        {
            if (number % 5 == 0) return number;
            int result = (number + Math.Abs((number % 5) - 5));
            return result;

        }
    }
}
