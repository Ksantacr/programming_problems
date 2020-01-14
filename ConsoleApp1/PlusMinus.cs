using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PlusMinus
    {
        public static void plusMinus(int[] arr)
        {
            int total = arr.Length;
            int positives = 0;
            int negatives = 0;
            int zeros = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > 0)
                {
                    positives++;
                }
                else if (arr[j] < 0)
                {
                    negatives++;
                }
                else
                {
                    zeros++;
                }
            }
            decimal percentagePositives = 0m;
            percentagePositives = (positives / (decimal)total);
            float percentageNegatives = (negatives / (float)total);
            double percentageZeros = ((double)zeros / (double)total);

            Console.WriteLine(percentagePositives);
            Console.WriteLine(percentageNegatives);
            Console.WriteLine(percentageZeros);

        }
    }
}
