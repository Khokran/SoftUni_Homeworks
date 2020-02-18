using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var lake = new Lake(inputNumbers);

            Console.WriteLine(String.Join(", ", lake));

            foreach (var currStone in lake)
            {
                Console.WriteLine(currStone);
            }
        }
    }
}
