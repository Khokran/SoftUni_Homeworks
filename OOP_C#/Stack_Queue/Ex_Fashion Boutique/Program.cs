namespace Ex_Fashion_Boutique
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());

            int saveCapacity = 0;
            int robes = 1;
            int count = clothes.Count();

            for (int i = 0; i < count; i++)
            {
                int currentNum = clothes.Peek();

                if (currentNum + saveCapacity <= capacity)
                {
                    saveCapacity += clothes.Pop();
                }
                else
                {
                    saveCapacity = clothes.Pop();
                    robes++;
                }
            }
            Console.WriteLine(robes);
        }
    }
}
