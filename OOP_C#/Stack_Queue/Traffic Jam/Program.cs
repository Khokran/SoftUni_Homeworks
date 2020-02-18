using System;
using System.Collections;
using System.Collections.Generic;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            int count = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int countCars = 0;

            while (command?.ToLower() != "end")
            {
                if (command?.ToLower() == "green")
                {
                    int currCount = queue.Count > count ? count : queue.Count;
                    for (int i = 0; i < currCount; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        countCars++;
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{countCars} cars passed the crossroads.");
        }
    }
}
