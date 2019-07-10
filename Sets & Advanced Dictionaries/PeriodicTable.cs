using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> numbers = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int d = 0; d < input.Length; d++)
                {
                    numbers.Add(input[d]);
                }
                
            }

            var ordered = numbers.OrderBy(x => x);

            foreach (var item in ordered)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
