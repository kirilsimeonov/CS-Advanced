using System;
using System.Linq;
using System.Collections.Generic;

namespace ExamReal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liquidInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] physicalInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> liquids = new List<int>(liquidInput);
            Stack<int> physicals = new Stack<int>(physicalInput);
            Dictionary<string, int> items = new Dictionary<string, int>();

            items["Aluminium"] = 0;
            items["Carbon fiber"] = 0;
            items["Glass"] = 0;
            items["Lithium"] = 0;


            while (liquids.Count>0 && physicals.Count>0)
            {

                int physical = physicals.Pop();
                int liquid = liquids[0];
                int sum = physical + liquid;

                if (sum!=25 && sum!=50 && sum!=75 && sum!=100 )
                {
                    liquids.RemoveAt(0);
                    physicals.Push(physical + 3);
                }
                else
                {
                    if (sum==25)
                    {
                        items["Glass"]++;
                        liquids.RemoveAt(0);
                    }
                    if (sum == 50)
                    {
                        items["Aluminium"]++;
                        liquids.RemoveAt(0);
                    }
                    if (sum == 75)
                    {
                        items["Lithium"]++;
                        liquids.RemoveAt(0);
                    }
                    if (sum==100)
                    {
                        items["Carbon fiber"]++;
                        liquids.RemoveAt(0);
                    }
                }

            }

            if (items["Glass"]>0 && items["Aluminium"]>0 && items["Lithium"]>0 && items["Carbon fiber"]>0)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Count>0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }
            if (physicals.Count>0)
            {
                Console.WriteLine($"Physical items left: {string.Join(", ",physicals)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }
            var sorted = items.OrderBy(x => x.Key);
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
