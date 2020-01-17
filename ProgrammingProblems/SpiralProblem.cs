using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems
{
    public class SpiralProblem
    {
        public int[,] array { get; set; }
        int[] directions = new int[] { 1, 0, 0, 0 };

        public int rows { get; set; }
        public int columns { get; set; }
        public List<int> elements { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public SpiralProblem(int[,] array)
        {
            array = new int[3, 3];
            rows = array.GetLength(0);
            columns = array.GetLength(1);
            x = 0;
            y = 0;
            elements = new List<int>();

        }

        public int spiralResult()
        {
            move();
            return elements.Sum();
        }
        private void move()
        {
            moveRight();
        }

        private void moveUp()
        {
            if (!isCorner() && (elements.Count < rows * columns) && !(x == y))
            {
                elements.Add(array[x, y]);
                x--;
                moveUp();
            }
            else
            {
                x++;
                y++;
                moveRight();
            }
        }

        private void moveDown()
        {
            if (!isCorner())
            {
                elements.Add(array[x, y]);
                x++;
                moveDown();
            }
            else
            {
                x--;
                y--;
                moveLeft();
            }
        }

        private void moveLeft()
        {
            if (!isCorner())
            {
                elements.Add(array[x, y]);
                y--;
                moveLeft();
            }
            else
            {
                y++;
                x--;
                moveUp();
            }
        }

        private void moveRight()
        {
            if (!isCorner())
            {
                if (elements.Count == (rows * columns))
                {
                    return;
                }
                else
                {
                    elements.Add(array[x, y]);
                    y++;
                    moveRight();
                }
            }
            else
            {
                y--;
                x++;
                moveDown();
            }
        }
        private bool isCorner()
        {
            return x > rows - 1 || x < 0 || y > columns - 1 || y < 0 ? true : false;
        }
    }
}
