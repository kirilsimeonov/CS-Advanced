using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuel = double.Parse(input[1]);
                double consumption = double.Parse(input[2]);

                if (!cars.ContainsKey(model))
                {
                    cars[model] = new Car(model, fuel, consumption);
                }


            }
            string command = Console.ReadLine();
            while (command!="End")
            {
                var task = command.Split().ToArray();
                string carModel = task[1]; 
                double driveKm = double.Parse(task[2]);

                cars[carModel].Drive(driveKm);

                command = Console.ReadLine();
                
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Value.Model} {item.Value.FuelAmmount:F2} {item.Value.TravelledDistance}");
            }



            //Car car = new Car(model,fuel,consumption);
            //double km = double.Parse(Console.ReadLine());
            //car.Drive(km);
            //Console.WriteLine(car.FuelAmmount);
            //Console.WriteLine(car.TravelledDistance);

        }
    }
}
