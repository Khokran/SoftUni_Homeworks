using System;

namespace Ex_Arr_Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ChekNumbers(n);
        }

        private static void ChekNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }

            }
        }
        private static bool IsTopNumber(int i)
        {
            int sum = 0, digit = 0;
            bool isOdd = false, isTopNumber = false;
            while (i > 0)
            {
                digit = i % 10;
                if (digit % 2 != 0)
                {
                    isOdd = true;
                }
                sum += digit;
                i /= 10;
            }
            if (sum % 8 == 0 && isOdd)
            {
                isTopNumber = true;
            }
            else
            {
                isTopNumber = false;
            }
            return isTopNumber;
        }
    }
}
