using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods.Entities;

namespace WildFarm.Models.Animals.Entities
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightMultiplier => 0.40;

        protected override List<Type> PreferedFoodTypes => new List<Type> { typeof(Meat) };

        public override string AskFood()
        {
            return "Woof!";
        }
        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

    }
}
