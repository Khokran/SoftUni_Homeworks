using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_List_Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> bombPower = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            for (int position = 0; position < listNumbers.Count; position++)
            {
                if (listNumbers[position] == bombPower[0])
                {
                    for (int posToRemove = 1; posToRemove <= bombPower[1]; posToRemove++)
                    {
                        if (position - posToRemove < 0)
                        {
                            break;
                        }
                        else
                        {
                            listNumbers[position - posToRemove] = 0;
                        }
                    }
                    for (int j = 1; j <= bombPower[1]; j++)
                    {
                        if (position + j > listNumbers.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            listNumbers[position + j] = 0;
                        }
                    }
                    listNumbers[position] = 0;
                }
            }
            int finalSum = listNumbers.Sum();
            Console.WriteLine(finalSum);
        }
    }
}
