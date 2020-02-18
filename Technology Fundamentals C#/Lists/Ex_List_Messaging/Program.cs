using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_List_Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();


            int sumDigits = 0;
            while (number != 0)
            {
                sumDigits += number % 10;
                number /= 10;
            }


        }
    }
}
