using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_9.List_Of_Predicates
{
    class List_Of_Predicates
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var deviders = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var nums = new List<int>();
            bool Check(int x, int y) => x % y != 0;

            for (int i = 1; i <= n; i++)
            {
                bool isStillSearch = true;

                foreach (var devider in deviders)
                {
                    if (Check(i, devider))
                    {
                        isStillSearch = false;
                        break;
                    }
                }
                if (isStillSearch)
                {
                    nums.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
