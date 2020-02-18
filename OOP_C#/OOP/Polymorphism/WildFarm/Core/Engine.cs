using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Models.Animals.Contracts;
using WildFarm.Models.Animals.Entities;

namespace WildFarm.Core
{
    public class Engine
    {
        private List<Animal> animals;
        public Engine()
        {
            this.animals = new List<Animal>();
        }
        public void Run()
        {
            string command = Console.ReadLine();
            while (command != "End")
            {
                IAnimal animal = GetAnimal(command);
            }
        }

        private IAnimal GetAnimal(string command)
        {
            string[] animalArgs = command.Split(" ").ToArray();

            string type = animalArgs[0];
            string name = animalArgs[1];
            double weight = double.Parse(animalArgs[2]);

            IAnimal animal;
            if (type == "Owl")
            {
                double wingSize = double.Parse(animalArgs[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (type == "Hen")
            {
                double wingSize = double.Parse(animalArgs[4]);
                animal = new Hen(name, weight, wingSize);
            }
            else
            {
                string livingregion = animalArgs[4];

                if (type == "Dog")
                {
                    animal = new Dog(name, weight, livingregion);
                }
                else if (type == "Mouse")
                {
                    animal = new Mouse(name, weight, livingregion);
                }
                else
                {
                    string breed = animalArgs[5];
                }
            }
        }
    }
}
