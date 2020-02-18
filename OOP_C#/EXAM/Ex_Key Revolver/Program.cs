namespace Ex_Key_Revolver
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfBarrel = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] locks = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int valueOfIntelligence = int.Parse(Console.ReadLine());

            Stack<int> stackOfBullets = new Stack<int>(bullets);    // From back-to-front.
            Queue<int> queueOfLocks = new Queue<int>(locks);        // From front-to-back.

            int numberOfUsedBullets = 0;
            bool isTheSafeOpened = true;

            while (stackOfBullets.Count > 0 && queueOfLocks.Count > 0)
            {
                if (stackOfBullets.Peek() <= queueOfLocks.Peek()) // Returns the object at the top of the Collection,
                                                                  // without removing it.             
                {
                    Console.WriteLine("Bang!");
                    stackOfBullets.Pop();
                    queueOfLocks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    stackOfBullets.Pop();
                }
                numberOfUsedBullets++;

                if (numberOfUsedBullets % sizeOfBarrel == 0 && stackOfBullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                }

                if (stackOfBullets.Count == 0 && queueOfLocks.Count > 0)
                {
                    isTheSafeOpened = false;
                    break;
                }
            }
            if (isTheSafeOpened)
            {
                int earnedMoney = valueOfIntelligence - numberOfUsedBullets * priceOfBullet;

                Console.WriteLine($"{stackOfBullets.Count} bullets left. Earned ${earnedMoney}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queueOfLocks.Count}");
            }
        }
    }
}
