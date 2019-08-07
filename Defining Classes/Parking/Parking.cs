using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniParking
{
    public class Parking
    {


        private int capacity;

        public List<Car> Cars { get; set; }

        public int Count { get {
                return Cars.Count();
            }
         }

        public Parking(int capacity)
        {
            this.capacity = capacity;
            Cars = new List<Car>();
        }

        public string AddCar (Car car)
        {




                if (Cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
                {
                    return "Car with that registration number, already exists!";
                }
                else if (Cars.Count == capacity)
                {
                    return "Parking is full!";
                }
                else
                {
                    Cars.Add(car);
                    return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
                }
            
        }
        public string RemoveCar (string registrationNumber)
        {
            if (Cars.Any(x=>x.RegistrationNumber==registrationNumber))
            {
                Cars.RemoveAll(x => x.RegistrationNumber == registrationNumber);
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }
        public Car GetCar(string registrationNumber)
        {
            Car car1 = Cars.Where(x => x.RegistrationNumber == registrationNumber).FirstOrDefault();
            return car1;
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var item in registrationNumbers)
            {
                if (Cars.Any(x=>x.RegistrationNumber==item))
                {
                    Cars.RemoveAll(x => x.RegistrationNumber == item);
                }
            }
        }
    }
}
