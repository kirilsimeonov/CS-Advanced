using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> collection = new Dictionary<int, int>();
            


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!collection.ContainsKey(num))
                {
                    collection[num] = 0;
                }
                collection[num]++;
            }
            foreach (var item in collection)
            {
                //Console.WriteLine($"{item.Key} - {item.Value}");
                if (item.Value%2==0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
