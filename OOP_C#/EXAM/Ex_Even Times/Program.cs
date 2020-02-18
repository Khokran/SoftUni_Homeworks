namespace Ex_Even_Times
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new Dictionary<int, int>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(currNumber))
                {
                    numbers.Add(currNumber, 0);
                }
                numbers[currNumber]++;
            }
            int evenNumber = numbers.SingleOrDefault(number => number.Value % 2 == 0).Key;
            Console.WriteLine(evenNumber);
        }
    }
}
