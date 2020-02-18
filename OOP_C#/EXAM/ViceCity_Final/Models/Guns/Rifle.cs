namespace ViceCity.Models.Guns
{
    using System;

    public class Rifle : Gun
    {
        private const int InitialBulletsPerBarrel = 50;
        private const int InitialTotalBullets = 500;

        public Rifle(string name) 
            : base(name, InitialBulletsPerBarrel, InitialTotalBullets)
        {
        }

        public override int Fire()
        {
            this.BulletsPerBarrel -= 5;

            if (this.BulletsPerBarrel == 0)
            {
                this.BulletsPerBarrel = Math.Min(this.TotalBullets, InitialBulletsPerBarrel);
                this.TotalBullets -= this.BulletsPerBarrel;
            }

            return 5;
        }
    }
}
