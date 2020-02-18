namespace SoftUniParking
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var parking = new Parking(2);
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");

            Console.WriteLine(parking.AddCar(car));
            Console.WriteLine(parking.RemoveCar(car.RegistrationNumber));
            Console.WriteLine(parking.Count);
        }
    }
}
