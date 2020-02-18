using System;
using System.Linq;

namespace Ex_2._Knights_of_Honor
{
    class Knights_of_Honor 
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = names => Console.WriteLine("Sir " + String.Join(Environment.NewLine + "Sir " , names));

            string[] inputNames = Console.ReadLine()
                .Split();

            printNames(inputNames);
        }
    }
}
