using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{

    public class StartUp
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Box<string> list = new Box<string>();



            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }


            int[] command = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            int firstIndex = command[0];
            int secondIndex = command[1];



            Switch(list.Data, firstIndex, secondIndex);

            list.Data.ForEach(x => Console.WriteLine($"{x.GetType()}: {x}"));
        }





        private static void Switch<T>(List<T> list, int firstIndex, int secondIndex)
        {
            T temp = list[firstIndex];

            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
    }
}