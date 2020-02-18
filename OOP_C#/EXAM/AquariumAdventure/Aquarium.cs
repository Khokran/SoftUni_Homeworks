using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace AquariumAdventure
{
    public class Aquarium
    {
        private List<Fish> fishInPool;      //stores the entity <Fish>.

        public Aquarium(string name, int capacity, int size)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Size = size;             //the volume of the pool
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
            Fish fishToRemove = this.fishInPool.FirstOrDefault(s => s.Name == name);

            bool result = false;
            if (this.fishInPool.Contains(fishToRemove))
            {
                this.fishInPool.Remove(fishToRemove);
                result = true;
            }
            return result;
        }
        public Fish FindFish(string name)
        {
            Fish findFish = this.fishInPool.FirstOrDefault(s => s.Name == name);

            if (!fishInPool.Contains(findFish))
            {
                return null;
            }
            return findFish;
        }
        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Aquarium: {this.Name} ^ Size: {this.Size}");

            foreach (var fish in this.fishInPool)
            {
                sb.AppendLine($"{fish.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
