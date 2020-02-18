﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_Arr_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacityWagon = int.Parse(Console.ReadLine());

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                List<string> directions = command.Split().ToList();

                if (directions[0] == "Add")
                {
                    int customersInWagon = int.Parse(directions[1]);
                    wagons.Add(customersInWagon);
                }
                else
                {
                    int passangersToFit = int.Parse(directions[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passangersToFit <= capacityWagon)
                        {
                            wagons[i] += passangersToFit; break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
