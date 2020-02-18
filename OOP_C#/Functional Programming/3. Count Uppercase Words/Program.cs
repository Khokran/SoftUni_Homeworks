using System;
using System.Linq;

namespace _3._Count_Uppercase_Words
{
    class _3_Count_Uppercase_Words
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Where(w => Char.IsUpper(w[0]))
                 .Select(w =>
                 {
                     Console.WriteLine(w);
                     return w;
                 })
                 .Count();
        }
    }
}

