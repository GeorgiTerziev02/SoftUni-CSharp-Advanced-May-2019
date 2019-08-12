using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Salad
    {
        private List<Vegetable> vegetables;
        public string Name { get; set; }

        public Salad(string name)
        {
            this.Name = name;

            this.vegetables = new List<Vegetable> ();
        }

        public int GetTotalCalories()
        {
            return this.vegetables.Sum(p => p.Calories);
        }

        public int GetProductCount()
        {
            return this.vegetables.Count;
        }

        public void Add(Vegetable product)
        {
            this.vegetables.Add(product);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"* Salad {this.Name} is {GetTotalCalories()} calories and have {GetProductCount()} products:");

            foreach (var vegie in this.vegetables)
            {
                sb.AppendLine(vegie.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
