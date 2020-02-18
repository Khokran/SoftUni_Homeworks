using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity
{
    public class Player
    {
        private string name;
        private int bulletsPerBarrel;
        private int totalBullets;

        public Player()
        {
        }

        public Player(string name, int lifePoints, int bulletsPerBarrel)
        {
            this.Name = name;
            this.LifePoints = lifePoints;
        }

        public Player(string name, int lifePoints, int bulletsPerBarrel, int totalBullets) : this(name, lifePoints, bulletsPerBarrel)
        {
            this.totalBullets = totalBullets;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Player's name cannot be null or a whitespace!");
                }
                this.name = value;
            }
        }
        public int LifePoints
        {
            get
            {
                return this.bulletsPerBarrel;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player life points cannot be below zero!");
                }
                this.bulletsPerBarrel = value;
            }
        }
        public GunRepository GunRepository { get; set; }
        public bool IsAlive { get; set; }

        private void TakeLifePoints(int points)
        {
            if (points < 0)
            {
                return;
            }
        }

    }
}
