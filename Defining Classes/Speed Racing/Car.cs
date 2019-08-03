using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses

{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }


        public Car()
        {
            this.TravelledDistance = 0;
        }
        public Car(string Model, double FuelAmmount, double FuelConsumption) : this()
        {
            this.Model = Model;
            this.FuelAmmount = FuelAmmount;
            this.FuelConsumptionPerKilometer = FuelConsumption;
        }

        public void Drive(double km)
        {

            double fuelCapacityToTravel = this.FuelAmmount / this.FuelConsumptionPerKilometer;

            if (fuelCapacityToTravel >= km)
            {
                FuelAmmount -= (km * this.FuelConsumptionPerKilometer);
                TravelledDistance += km;

            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}


