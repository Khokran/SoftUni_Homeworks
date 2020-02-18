using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace AquariumAdventure
{
    public class Aquarium
    {        
        private List<Fish> fishInPool;      //private Dictionary<string, Fish> fishInPool;

        public Aquarium(string name, int capacity, int size)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Size = size;
            this.fishInPool = new List<Fish>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Size { get; set; }

        public int Count => this.fishInPool.Count;

        public void Add(Fish fish)
        {
            if (this.Count < this.Capacity)
            {
                this.fishInPool.Add(fish);
            }
        }

        public bool Remove(string name)
        {
            Fish fishToRemove = this.fishInPool.FirstOrDefault(f => f.Name == name);
            bool result = false;

            if (this.fishInPool.Contains(fishToRemove))
            {
                result = true;
                this.fishInPool.Remove(fishToRemove);
            }
            return false;
        }
        public Fish FindFish(string name)
        {
            Fish findCurrentFish = this.fishInPool.FirstOrDefault(f => f.Name == name);

            return findCurrentFish;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Aquarium: {this.Name} ^ Size: {this.Size}");

            foreach (var fish in fishInPool)
            {
                sb.AppendLine($"{fish.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
