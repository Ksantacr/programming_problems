using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            string rL = "";
            string Lr = "";
            int RightLeftDiagonal = 0;
            int LeftRightDiagonal = 0;
            int indexLeftRight = 0;
            int indexRightLeft = arr[0].Count - 1;
            for (int x = 0; x < arr[0].Count; x++)
            {

                LeftRightDiagonal += arr[x][indexLeftRight];
                Lr += arr[x][indexLeftRight] + ", ";
                indexLeftRight++;

                RightLeftDiagonal += arr[x][indexRightLeft];
                rL += arr[x][indexRightLeft] + ", ";
                indexRightLeft--;

            }
            return Math.Abs(RightLeftDiagonal - LeftRightDiagonal);
        }
    }
}
