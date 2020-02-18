using System;
using System.Text;

namespace _1._Car
{
    public class Car
    {
        private int year;
        private string make;
        private double fuel;

        public double FuelConsumption { get; set; }
        private Engine engine;
        public double Fuel
        {
            get
            {
                return Math.Floor(fuel);
            }
            set
            {
                if (value > 1)
                {
                    fuel += value;
                }
            }
        }
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                this.make = value;
            }
        }
        public string Model { get; set; }
        public int Year
        {
            get
            {
                if (year < 5)
                {
                    return year;
                }
                return year - 3;
            }
        }

        public Car()
        {
            make = "VW";
            Model = "Golf";
            year = 2025;
            fuel = 200;
            FuelConsumption = 10;
            engine = new Engine()
            {
                FuelType = "Diesel",
                HorsePower = 110
            };
        }
        public Car(string make, string model, int year)
            : this()
        {
            this.make = make;
            Model = model;
            this.year = year;
        }
        public Car(string make, string model, int year, double fuel, double consumption)
            : this(make, model, year)
        {
            this.fuel = fuel;
            FuelConsumption = consumption;
        }
        public int RealAge()
        {
            return year;
        }
        public void GetOld(int years)
        {
            this.year += years;
        }
        public void Drive(double distance)
        {
            double consumedFuel = distance / 100 * FuelConsumption;
            if (consumedFuel > fuel)
            {
                throw new ArgumentException("Go to gas station!");
            }
            fuel -= consumedFuel;
        }
        public string WhoAmI()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"Consumption: {this.FuelConsumption}");
            sb.AppendLine($"Fuel: {this.Fuel:F2}L");

            return sb.ToString();
        }
        public string HowPowerfullAmI()
        {
            return $"{engine.HorsePower} horse power";
        }
    }
}
