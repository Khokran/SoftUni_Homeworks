using System;
using System.Linq;

namespace Ex_Arr_FOLDandSUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int startIndex = (kArray.Length / 2) / 2;
            int endIndex = startIndex + kArray.Length / 2;

            int sumIndex = startIndex - 1;

            for (int i = startIndex; i < endIndex; i++)
            {
                int sum = kArray[i] + kArray[sumIndex];
                Console.Write($"{sum} ");
                sumIndex--;
                if (sumIndex < 0)
                {
                    sumIndex = kArray.Length - 1;
                }
            }
        }
    }
}
