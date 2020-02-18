using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_Speed_Racing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] carsData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string carModel = carsData[0];
                double fuelAmount = double.Parse(carsData[1]);
                double fuelConsumptionPerKm = double.Parse(carsData[2]);

                Car car = new Car(carModel, fuelAmount, fuelConsumptionPerKm);
                cars.Add(car);
            }
            while (true)
            {
                string inpuLine = Console.ReadLine();
                if (inpuLine == "End")
                {
                    break;
                }
                string[] data = inpuLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string carModel = data[1];
                double distance = double.Parse(data[2]);

                Car car = cars.FirstOrDefault(c => c.Model == carModel);
                car.Drive(distance);
            }
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
