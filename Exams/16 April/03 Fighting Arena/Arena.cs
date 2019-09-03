using System;
using System.Collections.Generic;
using System.Linq;
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
            Name = name;
            gladiators = new List<Gladiator>();

        }

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }
        public void Remove (string name)
        {
            if (gladiators.Any(x=>x.Name==name))
            {
                gladiators.RemoveAll(x=>x.Name==name);
            }
        }
        public Gladiator GetGladitorWithHighestStatPower()
        {
            var highest = gladiators.OrderByDescending(x => x.GetStatPower()).FirstOrDefault();
            return highest;
        }
        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            var highest = gladiators.OrderByDescending(x => x.GetWeaponPower()).FirstOrDefault();
            return highest;
        }
        public Gladiator GetGladitorWithHighestTotalPower()
        {
            var highest = gladiators.OrderByDescending(x => x.GetTotalPower()).FirstOrDefault();
            return highest;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{Name} - {Count} gladiators are participating");

            return result.ToString().Trim();
        }
    }
        
}
