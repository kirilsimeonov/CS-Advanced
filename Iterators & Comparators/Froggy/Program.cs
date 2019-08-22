using System;
using System.Collections.Generic;
using System.Linq;



namespace Froggy
{
    class Program

    {



        static void Main(string[] args)
        {

            var temList = new List<int>();

            var lake = new Lake(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());



            foreach (var item in lake)
            {
                temList.Add(item);
            }

            Console.WriteLine(string.Join(", ", temList));
        }
    }
}