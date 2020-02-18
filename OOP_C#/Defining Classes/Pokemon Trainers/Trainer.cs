using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Trainers
{
    public class Trainer
    {
        private string trainerName;

        public Trainer(string trainerName)
        {
            this.trainerName = trainerName;
        }

        public Trainer(string name, int numberOfBadges)
        {
            this.Name = name;
            this.NumberOfBadges = numberOfBadges;
            this.Pokemons = new List<Pokemon>();
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }

        public List<Pokemon> Pokemons { get; set; }
    }
}
