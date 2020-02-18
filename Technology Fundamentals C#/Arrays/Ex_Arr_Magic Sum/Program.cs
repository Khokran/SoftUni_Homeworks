using System;
using System.Linq;

namespace Ex_Arr_Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var number1 = 0;
            var number2 = 0;

            var specialSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayOfNumbers.Length; j++)
                {
                    if (arrayOfNumbers[i] + arrayOfNumbers[j] == specialSum)
                    {
                        number1 = arrayOfNumbers[i];
                        number2 = arrayOfNumbers[j];
                        Console.WriteLine($"{number1} {number2}");
                    }
                }

            }
        }
    }
}
