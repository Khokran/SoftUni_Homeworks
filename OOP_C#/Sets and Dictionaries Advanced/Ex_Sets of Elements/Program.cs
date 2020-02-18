namespace Ex_Sets_of_Elements
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int firstSetSize = size[0];
            int secondSetSize = size[1];

            for (int i = 0; i < firstSetSize; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                firstSet.Add(currNumber);
            }
            for (int i = 0; i < secondSetSize; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                secondSet.Add(currNumber);
            }
            foreach (var currItem in firstSet)
            {
                if (secondSet.Contains(currItem))
                {
                    Console.Write(currItem + " ");
                }
            }
        }
    }
}
