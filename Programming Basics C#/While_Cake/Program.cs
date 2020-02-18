using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lendth = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int sizeCake = lendth * width;

            while (sizeCake >= 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                sizeCake -= int.Parse(input);
            }
            if (sizeCake >= 0)
            {
                Console.WriteLine($"{sizeCake} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(sizeCake)} pieces more.");
            }
        }
    }
}
