using System;
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
            Name = name;
            Stat = stat;
            Weapon = weapon;
        }

        public int GetTotalPower()
        {
            int sum = 0;
            sum = Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills + Stat.Strength +
                Weapon.Sharpness + Weapon.Size + Weapon.Solidity;
            return sum;

        }
        public int GetWeaponPower()
        {
            int sum = 0;
            sum = Weapon.Sharpness + Weapon.Size + Weapon.Solidity;
            return sum;
        }
        public int GetStatPower()
        {
            int sum = 0;
            sum = Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills + Stat.Strength;
            return sum;

        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{Name} {GetTotalPower()}");
            result.AppendLine($" Weapon Power: {GetWeaponPower()}");
            result.AppendLine($" Stat Power: {GetStatPower()}");

            return result.ToString().Trim();
        }

    }
}
