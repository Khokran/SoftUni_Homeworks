using System;

namespace Ex_Arr_Factoriel_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = long.Parse(Console.ReadLine());
            var secondNumber = long.Parse(Console.ReadLine());

            double result = (double)GetFactoriel(firstNumber) / GetFactoriel(secondNumber);
            Console.WriteLine($"{result:F2}");
        }
        private static long GetFactoriel(long a)
        {
            long factorial = 1;
            for (long i = 1; i <= a; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
