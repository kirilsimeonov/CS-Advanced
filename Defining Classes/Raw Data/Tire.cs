﻿using System;
namespace DefiningClasses
{
    public class Tire
    {
        public double Pressure { get; set; }
        public int Age { get; set; }

        public Tire()
        {
        }
        public Tire(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }
    }
}
