using System;
using System.Collections.Generic;

namespace Ex_TEXT_Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart(new char[] { '0' });
            int digit = int.Parse(Console.ReadLine());

            if (digit == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int decimalReminder = 0;
            int currentMultiplication = 0;
            var result = new List<int>();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currDigit = number[i] - '0';
                currentMultiplication = currDigit * digit;
                currentMultiplication += decimalReminder;
                result.Add(currentMultiplication % 10);
                decimalReminder = currentMultiplication / 10;
            }
            if (decimalReminder > 0)
            {
                result.Add(decimalReminder);
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
