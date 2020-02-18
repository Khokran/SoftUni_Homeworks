using System;
using System.Collections.Generic;
using WildFarm.Models.Foods.Entities;

namespace WildFarm.Models.Animals.Entities
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightMultiplier => 0.30;

        protected override List<Type> PreferedFoodTypes => new List<Type> {typeof(Vegetables), typeof(Meat) };

        public override string AskFood()
        {
            return "Meow";
        }
    }
}
