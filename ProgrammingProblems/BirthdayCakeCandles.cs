using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class BirthdayCakeCandles
    {
        // https://www.hackerrank.com/challenges/birthday-cake-candles/problem
        public static int birthdayCakeCandles(int[] ar)
        {
            int tallest = 0;
            Array.Sort(ar);
            Array.Reverse(ar);
            tallest = ar[0];
            return ar.Count(x => x == tallest);
        }
    }
}
