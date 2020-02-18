using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstNsum = 0;
            int secondNsum = 0;

            for (int i = 0; i < 2 * n ; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    firstNsum += num;
                }
                else
                {
                    secondNsum += num;
                }
            }
            if (firstNsum == secondNsum)
            {
                Console.WriteLine($"Yes, sum = {firstNsum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(firstNsum - secondNsum)}");
            }
        }
    }
}
