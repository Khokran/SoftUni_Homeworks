using System;

namespace Workshop
{
    public class Program
    {
        static void Main(string[] args)
        {
            var doublyLinedList = new DoublyLinkedList();

            doublyLinedList.AddLast(1);
            doublyLinedList.AddLast(2);
            doublyLinedList.AddLast(3);

            //doublyLinedList.RemoveLast(); 

            //doublyLinedList.Print(Console.WriteLine);
            //Console.WriteLine(doublyLinedList.Count == 2);

            int[] array = doublyLinedList.ToArray();

            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
