using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods.Entities;

namespace WildFarm.Models.Animals.Entities
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightMultiplier => 0.35;

        protected override List<Type> PreferedFoodTypes => new List<Type>
        { typeof(Vegetables),typeof(Fruit),typeof(Meat),typeof(Seeds)};

        public override string AskFood()
        {
            return "Cluck";
        }
    }
}
