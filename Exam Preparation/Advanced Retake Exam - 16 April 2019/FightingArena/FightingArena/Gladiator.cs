using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public string Name { get; set; }

        public Stat Stat { get; set; }

        public Weapon Weapon { get; set; }

        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }

        //•	GetTotalPower(): int – return the sum of the stat properties plus the sum of the weapon properties.
        //•	GetWeaponPower() : int - return the sum of the weapon properties.
        //• GetStatPower(): int - return the sum of the stat properties.

        public int GetTotalPower()
        {
            return Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills + Stat.Strength + Weapon.Sharpness + Weapon.Size + Weapon.Solidity;
        }

        public int GetWeaponPower()
        {
            return Weapon.Sharpness + Weapon.Size + Weapon.Solidity;
        }

        public int GetStatPower()
        {
            return Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills + Stat.Strength;
        }

        public override string ToString()
        {
            string result = $"{Name} - {GetTotalPower()}\n"
                + $"Weapon Power: {GetWeaponPower()}\n"
                + $"Stat Power: {GetStatPower()}";

            return result;
        }
    }
}
