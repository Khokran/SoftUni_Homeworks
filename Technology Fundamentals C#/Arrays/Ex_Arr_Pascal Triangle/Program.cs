using System;

namespace Ex_Arr_Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] pascalArray = new int[n][];

            for (int row = 0; row < n; row++)
            {
                pascalArray[row] = new int[row + 1];
                for (int col = 0; col < row + 1; col++)
                {
                    if (col > 0 && col < pascalArray[row].Length - 1)
                    {
                        pascalArray[row][col] = pascalArray[row - 1][col - 1] + pascalArray[row - 1][col];
                    }
                    else
                    {
                        pascalArray[row][col] = 1;
                    }
                }
            }
            foreach (int[] item in pascalArray)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
