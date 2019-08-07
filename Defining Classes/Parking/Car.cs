using System;
using System.Text;
namespace SoftUniParking
{
    public class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }



       
        public Car(string make, string model, int hp,string registration)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = hp;
            this.RegistrationNumber = registration;
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine($"Make: {this.Make}");
        //    sb.AppendLine($"Model: {this.Model}");
        //    sb.AppendLine($"HorsePower: {this.HorsePower}");
        //    sb.AppendLine($"RegistrationNumber: {this.RegistrationNumber}");

        //    return sb.ToString().Trim();
        //}
        public override string ToString()
        {
            //string result = $"Make: {Make}" +
            //    Environment.NewLine +
            //    $"Model: {Model}" +
            //    Environment.NewLine +
            //    $"HorsePower: {HorsePower}" +
            //    Environment.NewLine	+
            //    $"RegistrationNumber: {RegistrationNumber}";

            //return result;


            return $"Make: {this.Make}" + Environment.NewLine + $"Model: {this.Model}" +
                Environment.NewLine+ $"HorsePower: {this.HorsePower}" +
                    Environment.NewLine + $"RegistrationNumber: {this.RegistrationNumber}";
        }
    }
}
