using System;
using System.Linq;

namespace Ex_12._TriFunction_2
{
    class TriFunction_2
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> isLarger = (name, charsLehgth) => name.Sum(x => x) >= charsLehgth;

            Func<string[], Func<string, int, bool>, string> nameFilter = (inputNames, isLargerFilter) =>
            inputNames.FirstOrDefault(x => isLargerFilter(x, length));

            string result = nameFilter(names, isLarger);

            Console.WriteLine(result);
        }
    }
}
