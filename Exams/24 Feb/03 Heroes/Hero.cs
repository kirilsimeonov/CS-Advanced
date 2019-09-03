using System;
using System.Text;

namespace Heroes
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Item Item { get; set; }
       
         public Hero(string name, int level, Item item)
        {
            Name = name;
            Level = level;
            Item = item;
        }

        public override string ToString()
        {
            StringBuilder heroResult = new StringBuilder();
            heroResult.AppendLine($"Hero: {Name} - {Level}lvl");

            heroResult.AppendLine(Item.ToString());


            return heroResult.ToString().Trim();
        }
    }
}
