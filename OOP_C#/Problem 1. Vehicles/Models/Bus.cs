namespace VehiclesExtension.Models
{
    public class Bus : Vehicle 
    {
        private const double summerCosnsumtion = 1.4;

        public Bus(double fuelQuantity, double fuelConsumptionLitersPerKm, double tankCapacity)
            : base(fuelQuantity, fuelConsumptionLitersPerKm, tankCapacity)
        {
        }
        public string DriveEmpty(double km)
        {
            return base.Drive(km);
        }
        public override string Drive(double km)
        {
            if (FuelQuantity - (FuelConsumptionLitersPerKm + summerCosnsumtion) * km > 0)
            {
                FuelQuantity -= (FuelConsumptionLitersPerKm + summerCosnsumtion) * km;
                return $"{this.GetType().Name} travelled {km} km";
            }
            return $"{this.GetType().Name} needs refueling";
        }
    }
}