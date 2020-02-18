using System;
using System.Linq;

namespace Ex_12._TriFunction
{
    class TriFunction 
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                       .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                       .ToList();

            string result = names.FirstOrDefault(n => n.ToCharArray()
                                                       .Select(c => (int)c)
                                                       .Sum() >= length);
            Console.WriteLine(result);
        }
    }
}
