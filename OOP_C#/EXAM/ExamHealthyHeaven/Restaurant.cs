using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace ExamHealthyHeaven
{
    public class Restaurant
    {
        private List<Salad> salads;

        public Restaurant(string name)
        {
            this.Name = name;
            this.salads = new List<Salad>();
        }
        public string Name { get; set; }

        public void Add(Salad salad)
        {
            this.salads.Add(salad);
        }
        public bool Buy(string name)   //removes a salad by given name, if such exists, and returns boolean
        {
            Salad saladToBuy = this.salads.FirstOrDefault(s => s.Name == name);

            bool result = false;
            if (this.salads.Contains(saladToBuy))
            {
                this.salads.Remove(saladToBuy);
                result = true;
            }
            return result;
        }
        public Salad GetHealthiestSalad()  //returns the healthiest salad.
        {
            int healthistSalad = int.MaxValue;

            foreach (var salad in this.salads)
            {
                if (salad.GetTotalCalories() < healthistSalad)
                {
                    healthistSalad = salad.GetTotalCalories();
                }
            }
            Salad healthiestSalad = this.salads.FirstOrDefault(s => s.GetTotalCalories() == healthistSalad);

            return healthiestSalad;
        }
        public string GenerateMenu()   //returns a string in the following format:
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Name} have {this.salads.Count} salads: ");

            foreach (var salad in this.salads)
            {
                sb.AppendLine($"{salad.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
