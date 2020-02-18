using System;
using System.Linq;

namespace Ex_Custom_Comparator
{
    class Custom_Comparator 
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                            .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();

            nums = nums.OrderBy(n => n % 2 != 0).ThenBy(n => n).ToList();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
