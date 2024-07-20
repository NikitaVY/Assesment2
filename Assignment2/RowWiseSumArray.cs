using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class RowWiseSumArray
    {
        static void Main()
        {
            int[,] rows = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < rows.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < rows.GetLength(1); j++)
                {
                    sum += rows[i, j];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
