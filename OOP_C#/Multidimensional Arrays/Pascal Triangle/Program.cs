using System;
using System.Collections.Generic;
using System.Linq;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            long[][] triangle = new long[height][];
            int cols = 1;

            for (int i = 0; i < height; i++)
            {
                triangle[i] = new long[cols];
                triangle[i][0] = 1;
                triangle[i][cols - 1] = 1;

                if (cols > 2)
                {
                    long[] prevRow = triangle[i - 1];
                    for (int j = 1; j < cols - 1; j++)
                    {
                        triangle[i][j] = prevRow[j] + prevRow[j - 1];
                    }
                }
                cols++;
            }
            foreach (var item in triangle)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
