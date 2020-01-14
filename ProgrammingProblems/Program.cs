using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //BirthdayCakeCandles.birthdayCakeCandles(new int[] { 82, 49, 82, 82, 41, 82, 15, 63, 38, 25 });

            GradingStudents.gradingStudents(new List<int> { 73, 67, 38, 33 });

            //MiniMaxSum.miniMaxSum(new int[] { 5, 1, 2, 3, 4 });

            //StairCase.staircase(6);

            //PlusMinus.plusMinus(new int[] { -4, 3, -9, 0, 4, 1 });

            //diagonalDifference();

            //Question01 q1 = new Question01();
            //string q1_r = q1.encrypt("dcj", "I love prOgrAmming!");

            //Question02 q2 = new Question02();
            //long[] q2_r = q2.track(new long[] { 65647440, 199644521 });

            //Question03 q3 = new Question03();
            //string q3_r = q3.nthCase(3, "Greetings, this is AN EXAMPLE!");

            //Question04 q4 = new Question04();
            //int q4_r = q4.series(1); //fail

            //Question05 q5 = new Question05();
            //string q5_r = q5.decrypt("hi", "hhiighhiEr hiordhiEr fhiUncthiihions");

            //Question06 q6 = new Question06();
            //var q6_r = q6.angles(new[] { "4:00", "16:00", "blabla", "20:21", "26:88" });

            //Question07 q7 = new Question07();
            //var q7_r = q7.mob(7);

        }

        private static void diagonalDifference()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            Console.WriteLine(DiagonalDifference.diagonalDifference(arr));
        }

    }
}
