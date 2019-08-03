using System;
namespace DefiningClasses
{
    public class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }

        public Cargo()
        {
        }

        public Cargo(int weight,string type)
        {
            Weight = weight;
            Type = type;
        }
    }
}
