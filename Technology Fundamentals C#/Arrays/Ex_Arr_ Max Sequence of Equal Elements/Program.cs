using System;
using System.Linq;

namespace Ex_Arr__Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int firstCouter = 0;
            int secondCounter = 0;
            int longestLine = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    firstCouter++;

                    if (firstCouter > secondCounter)
                    {
                        secondCounter = firstCouter;
                        longestLine = numbers[i];
                    }
                }
                else
                {
                    firstCouter = 0;
                }
            }
            for (int j = 0; j <= secondCounter; j++)
            {
                Console.Write(longestLine + " ");
            }
        }
    }
}
