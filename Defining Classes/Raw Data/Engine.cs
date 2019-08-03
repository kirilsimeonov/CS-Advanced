using System;
namespace DefiningClasses
{
    public class Engine
    {

        public int Speed { get; set; }
        public int Power { get; set; }

        public Engine()
        {
        }
        public Engine(int speed,int power)
        {
            Speed = speed;
            Power = power;
        }
    }
}
