using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> heroes;

        public HeroRepository()
        {
            this.heroes = new List<Hero>();
        }

        public void Add(Hero hero)
        {
            this.heroes.Add(hero);
        }

        public int Count
        {
            get { return this.heroes.Count; }       
        }

        public void Remove(string name)
        {
            var hero = this.heroes.FirstOrDefault(x => x.Name == name);

            this.heroes.Remove(hero);
        }

        public Hero GetHeroWithHighestStrength()
        {
            var hero = this.heroes.OrderByDescending(x => x.Item.Strength).FirstOrDefault();

            return hero;
        }

        public Hero GetHeroWithHighestAbility()
        {
            var hero = this.heroes.OrderByDescending(x => x.Item.Ability).FirstOrDefault();

            return hero;

        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero best = this.heroes.OrderByDescending(x => x.Item.Intelligence).FirstOrDefault();
            return best;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var hero in heroes)
            {
                sb.AppendLine(hero.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
