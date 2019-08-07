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
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);
                if (input.Length==2)
                {
                    engines[model] = new Engine(model, power);
                }
                if (input.Length==3)
                {
                    //int k;
                    //bool isNumber = int.TryParse(input[2], out k);

                    if (Char.IsDigit(input[2][0]))
                    {
                        string displacement = input[2];
                        engines[model] = new Engine(model, power, displacement);

                    }
                    else
                    {
                        string efficiency = input[2];
                        string displacement = "n/a";
                        engines[model] = new Engine(model, power, displacement, efficiency);
                    }
                    ;

                }
                if (input.Length==4)
                {
                    string displacement = input[2];
                    string efficiency = input[3];
                    engines[model] = new Engine(model, power, displacement, efficiency);
                }



            }
            //foreach (var item in engines)
            //{
            //    Console.WriteLine("KEY "+item.Key);
            //    Console.WriteLine("MODEL "+item.Value.Model);
            //    Console.WriteLine("POWER "+item.Value.Power);
            //    Console.WriteLine("DISPLACEMENT "+item.Value.Displacement);
            //    Console.WriteLine("EFFICIENCY "+item.Value.Efficiency);
            //}
            int m = int.Parse(Console.ReadLine());

            for (int d = 0; d < m; d++)
            {
                string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                Engine engine = engines[input[1]];
                if (input.Length==2)
                {
                    Car car = new Car(model, engine);
                    cars.Add(car);
                }
                if (input.Length==3)
                {

                    //int k;
                    //bool isNumber = int.TryParse(input[2], out k);

                    if (Char.IsDigit(input[2][0]))
                    {
                        string weight = input[2];
                        Car car = new Car(model, engine, weight);
                        cars.Add(car);
                    }
                    else
                    {
                        string color = input[2];
                        string weight = "n/a";
                        Car car = new Car(model, engine, weight, color);
                        cars.Add(car);
                    }


                }
                if (input.Length==4)
                {
                    string weight = input[2];
                    string color = input[3];
                    Car car = new Car(model, engine, weight, color);
                    cars.Add(car);
                }   




            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine(string.Format($"    Displacement: {car.Engine.Displacement}"));
                Console.WriteLine(string.Format($"    Efficiency: {car.Engine.Efficiency}"));
                Console.WriteLine(string.Format($"  Weight: {car.Weight}"));
                Console.WriteLine(string.Format($"  Color: {car.Color}"));
            }
        }
    }
}
