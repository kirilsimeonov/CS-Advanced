using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {        
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int set1 = input[0];
            int set2 = input[1];
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();


            for (int i = 0; i < set1; i++)
            {
                int num = int.Parse(Console.ReadLine());
                first.Add(num);
            }

            for (int d = 0; d < set2; d++)
            {
                int num = int.Parse(Console.ReadLine());
                second.Add(num);
            }

            foreach (var num in first)
            {
                if (second.Contains(num))
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();


        }
    }
}
