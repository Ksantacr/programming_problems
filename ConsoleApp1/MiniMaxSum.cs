using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MiniMaxSum
    {
        public static void miniMaxSum(int[] arr)
        {
            long minSum = 0;
            long maxSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int tmp = arr[i];
                    if (arr[i] < arr[j])
                    {
                        arr[i] = arr[j];
                        arr[j] = tmp;

                    }
                }
            }
            for (int i = 0;  i < 4; i++)
            {

                maxSum += arr[i];
                minSum += arr[(arr.Length - 1) - i];

            }
            Console.WriteLine(minSum);
            Console.WriteLine(maxSum);

        }
    }
}
