using System;
using System.Linq;

namespace Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();




            var sortednumbers = numbers.OrderBy(x => x % 2 != 0).ThenBy(x => x);






            Func<int, int, int> comparator = (a, b) =>
            {
                if (a % 2 == 0 && b % 2 != 0)
                {
                    return -1;
                }
                else if (a % 2 != 0 && b % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return a.CompareTo(b);
                }
            };

            Array.Sort(numbers, new Comparison<int>(comparator));
            Console.WriteLine(string.Join(' ', numbers));
        }

    }
}
