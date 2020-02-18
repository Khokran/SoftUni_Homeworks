using System;
using System.Linq;
using System.Collections.Generic;

namespace Exam_TrojanInvasion
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<int> platesList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Stack<int> warriorsStack = new Stack<int>();

            Queue<int> platesQueue = new Queue<int>(platesList);
            for (int i = 1; i <= n; i++)
            {
                List<int> warriorsList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                AddWarriors(warriorsStack, warriorsList);

                if (i % 3 == 0)
                {
                    int additionalPlates = int.Parse(Console.ReadLine());
                    platesList.Add(additionalPlates);
                }
                while (warriorsStack.Count > 0 && platesList.Count > 0)
                {
                    int currWarrior = warriorsStack.Pop();
                    int currPlate = platesList[0];

                    if (currWarrior > currPlate)
                    {
                        currWarrior -= currPlate;
                        warriorsStack.Push(currWarrior);
                        platesList.RemoveAt(0);
                    }
                    else if (currWarrior < currPlate)
                    {
                        currPlate -= currWarrior;
                        platesList[0] = currPlate;
                    }
                    else
                    {
                        platesList.RemoveAt(0);
                    }
                }
                if (platesList.Count == 0)
                {
                    break;
                }
            }
            if (platesList.Count == 0)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine($"Warriors left: {String.Join(", ", warriorsStack)}");
            }
            else
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {String.Join(", ", platesList)}");
            }
        }
        private static void AddWarriors(Stack<int> warriorsStack, List<int> warriorsList)
        {
            foreach (var war in warriorsList)
            {
                warriorsStack.Push(war);
            }
        }
    }
}
