﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_List_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "Delete")
                {
                    int elementRemove = int.Parse(tokens[1]);
                    numbers.RemoveAll(element => element == elementRemove);
                }
                else if (tokens[0] == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int position = int.Parse(tokens[2]);
                    numbers.Insert(position, element);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
