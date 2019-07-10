using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" -> ").ToArray();
                string color = input[0];
                var items = input[1].Split(",").ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }
                for (int d = 0; d < items.Length; d++)
                {
                    if (!wardrobe[color].ContainsKey(items[d]))
                    {
                        wardrobe[color][items[d]] = 0;
                    }
                    wardrobe[color][items[d]]++;
                }
            }
            var finalInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string finalColor = finalInput[0];
            string item = finalInput[1];

            foreach (var clothing in wardrobe)
            {
                Console.WriteLine($"{clothing.Key} clothes:");
                foreach (var itemm in clothing.Value)
                {
                    if (clothing.Key==finalColor && itemm.Key==item)
                    {
                        Console.WriteLine($"* {itemm.Key} - {itemm.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {itemm.Key} - {itemm.Value}");
                    }
                }
            }


        }
    }
}
