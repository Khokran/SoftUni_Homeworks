using System;

namespace LAB_SingleInheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myList = new CustomList<int>();

            for (int i = 1; i < 50; i++)
            {
                myList.Add(i);
            }
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(myList.RemoveRandomElement());
            }
        }
    }
}
