using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace ExamHealthyHeaven
{
    public class Salad
    {
        private List<Vegetable> products;  //stores the entity <Vegetable>.

        public Salad(string name)
        {
            this.Name = name;
            this.products = new List<Vegetable>();  //initialize the products with a new instance of the collection.
        }
        public string Name { get; set; }

        public void Add(Vegetable product)
        {
            this.products.Add(product);   //adds an entity to the products.
        }
        public int GetTotalCalories()
        {
            return this.products.Sum(p => p.Calories);   //returns the "sum" of all vegetable calories.
        }
        public int GetProductCount()   
        {
            return this.products.Count;   //returns the Count of products.
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"* Salad {this.Name} is {this.GetTotalCalories()} calories and have {this.GetProductCount()} products:");

            foreach (var product in this.products)
            {
                sb.AppendLine($"{product.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
