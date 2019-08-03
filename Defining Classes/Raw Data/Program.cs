using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();


            for (int i = 0; i < n; i++)
            {
               
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                Engine engine = new Engine(engineSpeed,enginePower);
                Cargo cargo = new Cargo(cargoWeight,cargoType);
                List<Tire> tires = new List<Tire>();
                Tire tire1 = new Tire(tire1Pressure,tire1Age);
                tires.Add(tire1);
                Tire tire2 = new Tire(tire2Pressure, tire2Age);
                tires.Add(tire2);
                Tire tire3 = new Tire(tire3Pressure, tire3Age);
                tires.Add(tire3);
                Tire tire4 = new Tire(tire4Pressure, tire4Age);
                tires.Add(tire4);

                cars[model] = new Car(model,engine, cargo);
                cars[model].Tires = tires;  
                
            }

            string command = Console.ReadLine();

            if (command=="fragile")
            {

                var fragileCars = cars.Where(x => x.Value.Cargo.Type == "fragile").Where(x => x.Value.Tires.Any(y => y.Pressure < 1)).ToArray();
                foreach (var item in fragileCars)
                {
                    Console.WriteLine(item.Key);
                }

            }
            else if (command=="flamable")
            {
                var flammableCars = cars.Where(x => x.Value.Cargo.Type == "flamable").Where(x => x.Value.Engine.Power > 250).ToArray();
                foreach (var item in flammableCars)
                {
                    Console.WriteLine(item.Key);
                }
            }

            //foreach (var item in cars)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine($"{item.Value.Engine.Speed} {item.Value.Engine.Power}");
            //    Console.WriteLine($"{item.Value.Cargo.Weight} {item.Value.Cargo.Type}");
            //    foreach (var tire in item.Value.Tires)
            //    {
            //        Console.WriteLine($"{tire.Pressure} {tire.Age}");
            //    }

            //}
        }
    }
}
