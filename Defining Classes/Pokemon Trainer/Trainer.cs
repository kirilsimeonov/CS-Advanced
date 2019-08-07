using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Trainer
    {
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }


        //public List<Pokemon> Pokemons
        //{
        //    get
        //    {
        //        return this.pokemons;
        //    }
        //    set
        //    {
        //        this.pokemons = new List<Pokemon>();
        //    }
        //}

        public Trainer()
        {
            Badges = 0;
            Pokemons = new List<Pokemon>();
        }
        public Trainer(string name) : this()
        {
            this.Name = name;

        }
    }
}
