using System;
namespace DefiningClasses
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine()
        {
            Efficiency = "n/a";
            Displacement = "n/a";

        }
        public Engine(string model,int power) : this()
        {
            Model = model;
            Power = power;
        }
        public Engine(string model,int power, string displacement) : this(model,power)
        {
            Displacement = displacement;
        }
        public Engine(string model,int power,string displacement, string efficiency) : this(model,power,displacement)

        {

            Efficiency = efficiency;
        }
    }
}
