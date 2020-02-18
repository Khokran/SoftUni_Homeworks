using System;

namespace ExGenericBoxofString
{
    class Program
    {
        static void Main(string[] args) 
        {
            Box<string> myBox = new Box<string>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                myBox.Add(input);
            }
            string result = myBox.ToString();
            Console.WriteLine(result);
        }
    }
}
