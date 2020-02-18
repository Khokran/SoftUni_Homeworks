using System;
using System.Collections.Generic;

namespace Exam_ClubParty
{
    class Program
    {
        public static void Main()
        {
            int maxCapacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            Stack<string> elements = new Stack<string>();
            Queue<string> halls = new Queue<string>();
            List<int> allGoups = new List<int>();
            int currCapacity = 0;

            while (elements.Count > 0)
            {
                string currElement = elements.Pop();
                bool isNumber = int.TryParse(currElement, out int parsedNumber);

                if (!isNumber)
                {
                    halls.Enqueue(currElement);
                }
                else
                {
                    if (halls.Count==0)
                    {
                        continue;
                    }
                    if (currCapacity+parsedNumber >maxCapacity)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {String.Join(", ", allGoups)}");
                        allGoups.Clear();
                        currCapacity = 0;
                    }
                    if (halls.Count>0)
                    {
                    allGoups.Add(parsedNumber);
                    currCapacity += parsedNumber;
                    }
                }
            }
        }
    }
}
