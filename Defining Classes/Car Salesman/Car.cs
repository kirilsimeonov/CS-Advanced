using System;
namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }


        public Car()
        {
            Color = "n/a";
            Weight = "n/a";

        }
        public Car(string model, Engine engine) : this ()

        {
            Model = model;
            Engine = engine;
        }
        public Car(string model, Engine engine, string weight) : this(model,engine)
        {
            Weight = weight;
        }

        public Car(string model,Engine engine,string weight,string color) : this(model,engine,weight)
        {
           
            Color = color;
        }
    }
}
