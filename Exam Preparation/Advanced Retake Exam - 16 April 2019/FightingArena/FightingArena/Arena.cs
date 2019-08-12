using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;

        public string Name { get; set; }

        public int Count
        {
            get { return gladiators.Count; }
        }

        public Arena(string name)
        {
            this.Name = name;

            this.gladiators = new List<Gladiator>();
        }

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            Gladiator gladiatorToRemove=gladiators[0];

            foreach (var gladiator in gladiators)
            {
                if (gladiator.Name == name)
                {
                    gladiatorToRemove = gladiator;
                }
            }

            gladiators.Remove(gladiatorToRemove);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            Gladiator best = gladiators[0];

            foreach (var gladiator in gladiators)
            {
                if(gladiator.GetStatPower()>best.GetStatPower())
                {
                    best = gladiator;
                }
            }

            return best;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            Gladiator best = gladiators[0];

            foreach (var gladiator in gladiators)
            {
                if (gladiator.GetWeaponPower() > best.GetWeaponPower())
                {
                    best = gladiator;
                }
            }
            return best;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            Gladiator best = gladiators[0];

            foreach (var gladiator in gladiators)
            {
                if (gladiator.GetTotalPower() > best.GetTotalPower())
                {
                    best = gladiator;
                }
            }
            return best;

        }

        public override string ToString()
        {
            return $"{Name} - {Count} gladiators are participating.";
        }
    }
}
