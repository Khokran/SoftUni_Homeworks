using System;
using System.Collections.Generic;

namespace Ex_Ass_Arr_SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, string>();

            for (int i = 1; i <= n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string order = command[0];
                string name = command[1];

                if (order == "register")
                {
                    string plateNumber = command[2];
                    if (!dict.ContainsKey(name))
                    {
                        dict[name] = plateNumber;
                        Console.WriteLine($"{name} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }
                else if (order == "unregister")
                {
                    if (dict.ContainsKey(name))
                    {
                        dict.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var name in dict)
            {
                Console.WriteLine($"{name.Key} => {name.Value}");
            }
        }
    }
}
