using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> collection;

        public Trainer(string name,int badges,List<Pokemon>collection)
        {
            this.name = name;
            this.numberOfBadges = badges;
            this.collection = collection;

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Badges
        {
            get { return this.numberOfBadges; }
            set { this.numberOfBadges = value; }
        }
        public List<Pokemon> Collection
        {
            get { return this.collection; }
            set { this.collection = value; }
        }

    }
}
