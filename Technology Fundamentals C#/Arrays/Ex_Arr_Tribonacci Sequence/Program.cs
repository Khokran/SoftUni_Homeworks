using System;
using System.Numerics;

namespace Ex_Arr_Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            if (num <= 0) Console.WriteLine(0);
            else if (num == 1) Console.Write("1");
            else if (num == 2) Console.Write("1 1");
            else if (num == 3) Console.Write("1 1 2");
            else Console.Write("1 1 2 "); GetTribonacci(num);
        }
        private static void GetTribonacci(BigInteger num)
        {
            BigInteger num3 = 1;
            BigInteger num2 = 1;
            BigInteger num1 = 2;
            BigInteger max = num;
            for (int i = 0; i < max - 3; i++)
            {
                num = num3 + num2 + num1;
                num3 = num2;
                num2 = num1;
                num1 = num;
                Console.Write($"{num} ");
            }
        }
    }
}
