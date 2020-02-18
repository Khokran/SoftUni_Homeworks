using System;
using System.Linq;

namespace LAB_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(Sum(input, 0));
        }
        private static int Sum(int[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                return arr[index];
            }
            return arr[index] + Sum(arr, ++index);
        }
        private static long Factoriel(int number)
        {
            if (number==0)
            {
                return 1L;
            }
            return number * Factoriel(--number);
        }
    }
}
