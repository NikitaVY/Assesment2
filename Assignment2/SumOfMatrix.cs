using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class SumOfMatrix
    {
        static void Main()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrix2 = { { 2, 3, 4 }, { 3, 4, 5 }, { 4, 5, 6, } };
            int[,] sum = new int[3, 3];
            for (int i = 0;i< 3;i++)
            {
                for (int j = 0;j < 3; j++)
                {
                    sum[i,j] = matrix[i,j] + matrix2[i,j];
                }
            }
            Console.WriteLine("Sum of matrices is :");
            for (int i = 0; i< 3; i++)
            {
                for (int j = 0;  j < 3; j++)
                {
                    Console.Write(sum[i,j] + "\t" );
                }
                Console.WriteLine();
            }
        }
    }
}
