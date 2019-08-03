using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses

{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> Tires { get; set; }

        //public List<Tire> Tires
        //{
        //    get {
        //        return this.tires; 
        //    }
        //    set
        //    {

        //    }
        //}

        public Car()
        {
            Tires = new List<Tire>();
        }
        public Car(string model, Engine engine, Cargo cargo) : this()
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
        }

    }
}
