using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_ListyIterators
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterators<string> listyIterators = null;
            string command = Console.ReadLine();
            while (command != "END")
            {
                try
                {
                    if (command.Contains("Create"))
                    {
                        List<string> items = command.Split().Skip(1).ToList();
                        listyIterators = new ListyIterators<string>(items);
                    }
                    else if (command == "Print")
                    {
                        listyIterators.Print();
                    }
                    else if (command == "NasNext")
                    {
                        Console.WriteLine(listyIterators.HasNext());
                    }
                    else if (command == "Move")
                    {
                        Console.WriteLine(listyIterators.Move());
                    }
                    command = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
