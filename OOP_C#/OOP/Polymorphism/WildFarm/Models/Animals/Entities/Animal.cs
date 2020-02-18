using System;
using System.Collections.Generic;
using WildFarm.Exceptions;
using WildFarm.Models.Animals.Contracts;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Models.Animals.Entities
{
    public abstract class Animal : IAnimal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }
        protected abstract double WeightMultiplier { get;}
        protected abstract List<Type> PreferedFoodTypes { get; }
        public abstract string AskFood();

        public void Feed(IFood food)
        {
            if (!this.PreferedFoodTypes.Contains(food.GetType()))
            {
                throw new InvalidOperationException(String.Format
                    (ExceptionMessages.InvalidFoodTypeException, 
                    this.GetType().Name, food.GetType().Name));
            }
            this.Weight += food.Quantity * this.WeightMultiplier;
            this.FoodEaten += food.Quantity;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
