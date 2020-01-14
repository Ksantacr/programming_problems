using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class BirthdayCakeCandles
    {
        public static int birthdayCakeCandles(int[] ar)
        {
            int tallest = 0;
            int candlesCanBlow = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {
                    int tmp = ar[i];
                    if (ar[i] < ar[j])
                    {
                        ar[i] = ar[j];
                        ar[j] = tmp;
                    }
                }
            }
            tallest = ar[0];

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < tallest)
                {
                    candlesCanBlow++;
                }
            }
            return candlesCanBlow;
        }
    }
}
