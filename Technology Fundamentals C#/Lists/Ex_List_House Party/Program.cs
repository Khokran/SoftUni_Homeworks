﻿using System;
using System.Collections.Generic;

namespace Ex_List_House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            List<string> guest = new List<string>();

            for (int i = 0; i < commands; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                if (tokens.Length == 3)
                {
                    if (!guest.Contains(tokens[0]))
                    {
                        guest.Add(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is already in the list!");
                    }
                }
                else if (tokens.Length == 4)
                {
                    if (guest.Contains(tokens[0]))
                    {
                        guest.Remove(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is not in the list!");
                    }
                }
            }
            foreach (var person in guest)
            {
                Console.WriteLine(person);
            }
        }
    }
}
