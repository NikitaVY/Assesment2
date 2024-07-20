using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class SumAvgArray
    {
        static void Main()
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            int avg = sum/num.Length;
            Console.WriteLine($"Average of {avg} and Sum is {sum}");
        }
    }
}
