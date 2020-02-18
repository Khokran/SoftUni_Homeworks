using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity
{
    public class Gun : Player
    {
        private string name;
        private int bulletsPerBarrel;
        private int totalBullets;

        public Gun(string name, int bulletsPerBarrel , int totalBullets) 
            : base(name, bulletsPerBarrel, totalBullets)
        {
        }

        public Gun(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
        private void SetName(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be null or a white space!");
            }
            this.name = value;
        }
        public int BulletsPerBarrel
        {
            get
            {
                return this.bulletsPerBarrel;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Bullets cannot be below zero!");
                }
                this.bulletsPerBarrel = value;
            }
        }
        public int TotalBullets 
        {
            get
            {
                return this.totalBullets;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Total bullets cannot be below zero!");
                }
                this.totalBullets = value;
            }
        }
        public bool CanFire  { get; set; }

    }
}
