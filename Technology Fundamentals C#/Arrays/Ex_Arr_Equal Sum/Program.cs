using System;
using System.Linq;

namespace Ex_Arr_Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = array.Sum();

            for (int i = 0; i < array.Length; i++)
            {
                rightSum -= array[i];

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                leftSum += array[i];
            }
            Console.WriteLine("no");
        }
    }
}
