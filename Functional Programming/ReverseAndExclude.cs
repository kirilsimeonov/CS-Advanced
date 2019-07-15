using System;
using System.Linq;

namespace Reverse
{

    class Program
    {
        static void Main(string[] args)
        {



            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();




            int special = int.Parse(Console.ReadLine());
            Func<int, int, bool> tester = (x, y) => x % y != 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (tester(numbers[i], special))
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            Console.WriteLine();
        }
    }
}
