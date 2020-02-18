namespace VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        private const double summerFuelConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumptionLitersPerKm, double tankCapacity)
            : base(fuelQuantity, (fuelConsumptionLitersPerKm + summerFuelConsumption), tankCapacity)
        {
        }
    }
}