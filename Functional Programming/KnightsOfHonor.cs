using System;

namespace Knights
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Action<string> knight = n => Console.WriteLine($"Sir {n}");
            foreach (var inp in input)
            {
                knight(inp);
            }
        }
    }
}

