﻿using System;
using System.Linq;

namespace Ex_1._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = names => Console.WriteLine(String.Join(Environment.NewLine, names));

            string[] inputNames = Console.ReadLine()
                .Split();

            printNames(inputNames);
        }
    }
}
