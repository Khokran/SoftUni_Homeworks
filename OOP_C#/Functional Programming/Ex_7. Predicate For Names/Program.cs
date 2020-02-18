using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_7._Predicate_For_Names
{
    class Predicate_For_Names 
    {
        static void Main(string[] args)
        {
            int lengthNames = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Console.WriteLine(string.Join("\n", names.Where(n => n.Length <= lengthNames)));
        }
    }
}
