using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int currentCount = 1;
            double sum = 0;

            while (currentCount <= count)
            {
                double income = double.Parse(Console.ReadLine());
                if (income < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    sum += income;
                    Console.WriteLine($"Increase: {income:f2}");

                }
                currentCount++;
            }
            Console.WriteLine("Total: " + sum);
        }
    }
}
