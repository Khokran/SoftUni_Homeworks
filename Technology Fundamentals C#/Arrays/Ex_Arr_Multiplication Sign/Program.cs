using System;

namespace Ex_Arr_Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            ReturnSign(num1, num2, num3);
        }

        private static void ReturnSign(int num1, int num2, int num3)
        {
            int[] product = { num1, num2, num3 };
            int countNegative = 0;
            int countPositive = 0;

            for (int i = 0; i < product.Length; i++)
            {
                if (product[i] > 0)
                {
                    countPositive++;
                }
                else if (product[i] < 0)
                {
                    countNegative++;
                }
            }
            if (countPositive == 3 || countNegative == 2) Console.WriteLine("positive");
            else if (countNegative == 1 || countNegative == 3) Console.WriteLine("negative");
            else if (num1 == 0 || num2 == 0 || num3 == 0) Console.WriteLine("zero");
        }
    }
}
