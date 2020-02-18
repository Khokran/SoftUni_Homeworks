using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods.Entities;

namespace WildFarm.Models.Animals.Entities
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightMultiplier => 1.00;

        protected override List<Type> PreferedFoodTypes => new List<Type> { typeof(Meat) };

        public override string AskFood()
        {
            return "ROAR!!!";
        }
    }
}
