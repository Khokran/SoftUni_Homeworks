namespace ViceCity.Core.Factories
{
    using System;

    using Contracts;
    using Models.Guns;
    using Models.Guns.Contracts;

    public class GunFactory : IGunFactory
    {
        public IGun CreateGun(string type, string name)
        {
            IGun gun = null;

            if (type == "Pistol")
            {
                gun = new Pistol(name);
            }
            else if (type == "Rifle")
            {
                gun = new Rifle(name);
            }
            else
            {
                throw new ArgumentException("Invalid gun type!");
            }

            return gun;
        }
    }
}
