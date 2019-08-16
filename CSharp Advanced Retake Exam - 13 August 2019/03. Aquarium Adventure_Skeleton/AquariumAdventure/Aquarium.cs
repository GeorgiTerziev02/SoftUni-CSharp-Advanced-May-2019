using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquariumAdventure
{
    public class Aquarium
    {
        private List<Fish> fishes;
        public Aquarium(string name, int capacity, int size)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Size = size;

            this.fishes = new List<Fish>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Size { get; set; }

        public void Add(Fish fish)
        {
            if (this.fishes.Count + 1 <= Capacity)
            {
                if (this.fishes.FirstOrDefault(f => f.Name == fish.Name) == null)
                {
                    this.fishes.Add(fish);
                }
            }
        }

        public bool Remove(string name)
        {
            Fish fish = this.fishes.FirstOrDefault(f => f.Name == name);

            if (fish == null)
            {
                return false;
            }

            this.fishes.Remove(fish);

            return true;
        }

        public Fish FindFish(string name)
        {
            return this.fishes.FirstOrDefault(f => f.Name == name);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Aquarium: {this.Name} ^ Size: {this.Size}");

            foreach (var fish in fishes)
            {
                sb.AppendLine(fish.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
