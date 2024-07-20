using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class MaxElementArray
    {
        static void Main()
        {
            int[] arr = { 91, 25, 3, 4, 55, 70 };
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Maxixmum element of an Array is {max}");
        }
    }
}
