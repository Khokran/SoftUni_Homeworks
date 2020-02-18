using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] arr = new int[dim[0], dim[1]];
            int[] sum = new int[dim[1]];

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                int[] tokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr[row, col] = tokens[col];
                    sum[col]+= tokens[col];
                }
            }
            foreach (var item in sum)
            {
                Console.WriteLine(item);
            }
        }
    }
}
