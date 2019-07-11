using System;
using System.Linq;

namespace Find
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] boundary = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string condition = Console.ReadLine();

            Predicate<string> tester = n => n == "even";
            if (tester(condition))
            {
                for (int i = boundary[0]; i <= boundary[1]; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
            }


            else
            {

                for (int i = boundary[0]; i <= boundary[1]; i++)
                {

                    if (i % 2 != 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
