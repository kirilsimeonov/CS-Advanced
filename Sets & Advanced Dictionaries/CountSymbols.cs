using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> occur = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!occur.ContainsKey(input[i]))
                {
                    occur[input[i]] = 0;
                }
                occur[input[i]]++;
            }

            var ordered = occur.OrderBy(x=>x.Key);
            foreach (var item in ordered)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
             
        }
    }
}
