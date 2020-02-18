using System;
using System.Linq;

namespace Ex_Arr_Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] fromLeftDiagonal = new int[number];
            int[] fromRightDiagonal = new int[number];

            for (int i = 0; i < number; i++)
            {
                int[] currArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    fromLeftDiagonal[i] = currArray[0];
                    fromRightDiagonal[i] = currArray[1];
                }
                else
                {
                    fromLeftDiagonal[i] = currArray[1];
                    fromRightDiagonal[i] = currArray[0];
                }
            }
            Console.WriteLine(String.Join(" ", fromLeftDiagonal));
            Console.WriteLine(String.Join(" ", fromRightDiagonal));
        }
    }
}
