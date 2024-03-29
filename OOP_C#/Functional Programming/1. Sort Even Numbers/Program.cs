﻿using System;
using System.Linq;

namespace _1._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(',', Console.ReadLine()
                             .Split(',', StringSplitOptions.RemoveEmptyEntries)
                             .Select(Int32.Parse)
                             .Where(n => n % 2 == 0)
                             .OrderBy(n => n)));
        }
    }
}
