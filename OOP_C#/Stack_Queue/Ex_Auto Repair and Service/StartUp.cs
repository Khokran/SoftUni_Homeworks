namespace Ex_Auto_Repair_and_Service
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] carModels = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> queueOfCars = new Queue<string>(carModels);
            Stack<string> servedCars = new Stack<string>();

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                if (input == "Service" && queueOfCars.Count > 0)
                {
                    string currCar = queueOfCars.Dequeue();
                    servedCars.Push(currCar);
                    Console.WriteLine($"Vehicle {currCar} got served.");
                }
                else if (input.Contains("CarInfo"))
                {
                    string carName = input.Split('-')[1];
                    if (queueOfCars.Contains(carName))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (input == "History")
                {
                    Console.WriteLine(String.Join(", ", servedCars));
                }

                input = Console.ReadLine();
            }
            if (queueOfCars.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {String.Join(", ", queueOfCars)}");
            }
            Console.WriteLine($"Served vehicles: {String.Join(", ", servedCars)}");
        }
    }
}
