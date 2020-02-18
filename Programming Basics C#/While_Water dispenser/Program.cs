using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Water_dispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int pushes = 0;
            while (capacity > totalSum)
            {
                string buton = Console.ReadLine().ToLower();
                if (buton == "easy")
                {
                    totalSum += 50;
                }
                if (buton == "medium")
                {
                    totalSum += 100;
                }
                if (buton == "hard")
                {
                    totalSum += 200;
                }
                pushes++;
            }
            if (totalSum > capacity)
            {
                Console.WriteLine($"{totalSum - capacity}ml has been spilled."); return;
            }
            Console.WriteLine($"The dispenser has been tapped {pushes} times.");

        }

    }
}
