using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> repository;


        public int Count
        {
            get
            {
                return repository.Count;
            }
        }

        public HeroRepository()
        {
            repository = new List<Hero>();
        }
        public void Add(Hero hero)
        {
            repository.Add(hero);
        }
        public void Remove(string name)
        {
            if (repository.Any(x=>x.Name==name))
            {
                repository.RemoveAll(x => x.Name == name);
            }
        }
        public Hero GetHeroWithHighestStrength()
        {
            var highest = repository.OrderByDescending(x => x.Item.Strength).FirstOrDefault();
            return highest;

        }
        public Hero GetHeroWithHighestIntelligence()
        {
            var highest = repository.OrderByDescending(x => x.Item.Intelligence).FirstOrDefault();
            return highest;

        }
        public Hero GetHeroWithHighestAbility()
        {
            var highest = repository.OrderByDescending(x => x.Item.Ability).FirstOrDefault();
            return highest;

        }
        public override string ToString()
        {
            StringBuilder heroes = new StringBuilder();

            foreach (var itemm in repository)
            {
                heroes.AppendLine(itemm.ToString().Trim());
            }
            return heroes.ToString().Trim();
        }

    }


}
