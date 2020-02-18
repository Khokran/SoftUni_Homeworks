using System;
using System.Linq;

namespace Ex_3._Custom_Min_Function
{
    class Custom_Min_Function
    {
        static void Main(string[] args)
        {
            Action<int> printNumber = x => Console.WriteLine(x);
            Func<int[], int> minFunction = numbers =>
            {
                int minValue = int.MaxValue;
                foreach (var number in numbers)
                {
                    if (number < minValue)
                    {
                        minValue = number;
                    }
                }
                return minValue;
            };

            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
             
            int minNumber = minFunction(inputNumbers);
            printNumber(minNumber);
        }
    }
}
