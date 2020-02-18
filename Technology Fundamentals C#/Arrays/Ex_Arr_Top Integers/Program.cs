using System;
using System.Linq;

namespace Ex_Arr_Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                bool topInteger = true;
                if (i < arr.Length - 1)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (arr[i] < arr[j])
                            {
                                topInteger = false;
                                break;
                            }
                        }
                        if (topInteger)
                        {
                            Console.Write($"{arr[i]} ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{arr[i]} ");
                }
            }
        }
    }
}
