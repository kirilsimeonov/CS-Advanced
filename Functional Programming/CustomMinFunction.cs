using System;
using System.Linq;

namespace Custom
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> minValue = n => n.Min();

            Console.WriteLine(minValue(nums));
        }
    }
}
