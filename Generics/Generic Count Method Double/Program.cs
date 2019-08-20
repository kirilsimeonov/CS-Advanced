using System;
using System.Collections.Generic;




namespace GenericCountMethodDoubles
{
    public class Program
    {
        private static void Main()
        {
            Box<double> box = new Box<double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }

            double num = double.Parse(Console.ReadLine());



            Console.WriteLine(Compare(box.Data, num));
        }

        private static object Compare<T>(List<T> boxData, double number)
        {
            int count = 0;

            foreach (var item in boxData)
            {

                if (number.CompareTo(item) < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}