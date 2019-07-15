using System;
using System.Linq;

namespace Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());



            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int, bool> check = (x, y) => x % y == 0 ? true : false;

            for (int i = 1; i <= range; i++)
            {
                bool whetherPrint = true;


                foreach (int num in dividers)
                {

                    whetherPrint = check(i, num);
                    if (!whetherPrint)
                    {
                        break;
                    }
                }

                if (whetherPrint)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
