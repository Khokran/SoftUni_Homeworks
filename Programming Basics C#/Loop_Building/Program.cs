using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFloors = int.Parse(Console.ReadLine());
            int numberOfRooms = int.Parse(Console.ReadLine());

            for (int currentFloor = numberOfFloors; currentFloor >= 1; currentFloor--)
            {
                if (currentFloor == numberOfFloors)
                {
                    for (int apartment = 0; apartment < numberOfRooms; apartment++)
                    {

                        if (apartment == 0)
                        {
                            Console.Write($"L{currentFloor}0");
                        }
                        else if (apartment != 0)
                        {
                            Console.Write(" ");
                            Console.Write($"L{currentFloor}{apartment}");
                        }
                    }
                    Console.WriteLine();
                }
                else if (currentFloor % 2 != 0 && currentFloor != numberOfFloors && numberOfFloors != 1)
                {
                    for (int apartment = 0; apartment < numberOfRooms; apartment++)
                    {

                        if (apartment == 0)
                        {
                            Console.Write($"A{currentFloor}0");
                        }
                        else if (apartment != 0)
                        {
                            Console.Write(" ");
                            Console.Write($"A{currentFloor}{apartment}");
                        }


                    }

                    Console.WriteLine();
                }

                else if (currentFloor % 2 == 0 && currentFloor != numberOfFloors && numberOfFloors != 1)
                {
                    for (int office = 0; office < numberOfRooms; office++)
                    {
                        if (office == 0)
                        {
                            Console.Write($"O{currentFloor}0");
                        }
                        else if (office != 0)
                        {
                            Console.Write(" ");
                            Console.Write($"O{currentFloor}{office}");
                        }

                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
