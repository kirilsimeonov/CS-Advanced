using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();


            while (command!="Tournament")
            {
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);


                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainer(trainerName);
                }


                Pokemon pokemon = new Pokemon(pokemonName,pokemonElement, pokemonHealth);
                trainers[trainerName].Pokemons.Add(pokemon);



                command = Console.ReadLine();
            }

            //foreach (var item in trainers)
            //{
            //    Console.WriteLine(item.Value.Name);
            //    Console.WriteLine(item.Value.Badges);
            //    foreach (var pokemon in item.Value.Pokemons)
            //    {
            //        Console.WriteLine($"-{pokemon.Name} {pokemon.Element} {pokemon.Health}");
            //    }
            //}
            string element = Console.ReadLine();
            while (element!="End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Any(x=>x.Element==element))
                    {
                        trainer.Value.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Value.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                     }
                    trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                }



                //foreach (var item in trainers)
                //{
                //    Console.WriteLine(item.Value.Name);
                //    Console.WriteLine(item.Value.Badges);
                //    foreach (var pokemon in item.Value.Pokemons)
                //    {
                //        Console.WriteLine($"-{pokemon.Name} {pokemon.Element} {pokemon.Health}");
                //    }
                //}

                element = Console.ReadLine();
            }
            var sortedTrainers = trainers.OrderByDescending(x => x.Value.Badges);
            foreach (var item in sortedTrainers)
            {
                Console.WriteLine($"{item.Value.Name} {item.Value.Badges} {item.Value.Pokemons.Count}");
            }
        }
    }
}
