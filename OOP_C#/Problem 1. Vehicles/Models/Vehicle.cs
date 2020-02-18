using System;

namespace VehiclesExtension.Models
{
    public abstract class Vehicle
    {
        protected double fuelQuantity;

        protected double fuelConsumptionLitersPerKm;

        protected double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumptionLitersPerKm, double tankCapacity)
        { 
            TankCapacity = tankCapacity;
            FuelConsumptionLitersPerKm = fuelConsumptionLitersPerKm;

            if (fuelQuantity > TankCapacity)
            {
                FuelQuantity = 0;
            }
            else
            {
                FuelQuantity = fuelQuantity;
            }
        }

        public virtual double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            protected set
            {
                Validator.CheckValue(value);

                fuelQuantity = value;
            }
        }

        public virtual double FuelConsumptionLitersPerKm
        {
            get
            {
                return fuelConsumptionLitersPerKm;
            }
            protected set
            {
                Validator.CheckValue(value);
                fuelConsumptionLitersPerKm = value;
            }
        }

        public virtual double TankCapacity
        {
            get
            {
                return tankCapacity;
            }
            private set
            {
                Validator.CheckValue(value);
                tankCapacity = value;
            }
        }

        public virtual string Drive(double km)
        {
            if (FuelQuantity - FuelConsumptionLitersPerKm * km > 0)
            {
                FuelQuantity -= FuelConsumptionLitersPerKm * km;
                return $"{this.GetType().Name} travelled {km} km";
            }
            return $"{this.GetType().Name} needs refueling";
        }

        public virtual void Refuel(double liters)
        {
            if (liters > 0 && FuelQuantity + liters <= tankCapacity)
            {
                FuelQuantity += liters;
            }
            else if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else if (FuelQuantity + liters > tankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {liters} fuel in the tank");
            }
        }
    }
}