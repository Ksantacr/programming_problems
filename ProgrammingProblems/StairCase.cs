using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class StairCase
    {
        public static void staircase(int n)
        {
            string spaces = generateSpace(n);
            string symbol = string.Empty;
            for (int i = 0; i < n; i++)
            {
                spaces = spaces.Substring(0, (spaces.Length - 1));
                symbol += "#";
                Console.WriteLine(spaces + symbol);
            }

        }
        private static string generateSpace(int n)
        {
            string spaces = string.Empty;
            for (int i = 0; i < n; i++)
            {
                spaces += " ";
            }
            return spaces;
        }
    }
}
