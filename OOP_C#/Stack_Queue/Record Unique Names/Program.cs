namespace Record_Unique_Names
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            int namesCount = Int32.Parse(Console.ReadLine());
            var names = new HashSet<string>();

            for (int i = 0; i < namesCount; i++)
            {
                var entry = Console.ReadLine();
                names.Add(entry);
            }
            Console.WriteLine();

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
