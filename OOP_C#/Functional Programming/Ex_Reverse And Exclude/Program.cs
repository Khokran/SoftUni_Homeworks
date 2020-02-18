using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_Reverse_And_Exclude
{
    class Reverse_And_Exclude 
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
               .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            int n = int.Parse(Console.ReadLine());

            Predicate<int> result;
            result = x => x % n != 0;

            Console.Write(string.Join(" ", nums.Where(x => result(x)).Reverse()));
        }
    }
}
