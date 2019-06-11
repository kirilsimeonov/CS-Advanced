using System;
using System.Collections.Generic;
using System.Linq;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());



            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> qu = new Queue<int>(orders);
            int biggest = qu.Max();

            while (true)
            {
                if (qu.Count>0)
                {
                    if (foodQuantity >= qu.Peek())
                    {
                        foodQuantity -= qu.Dequeue();
                        //Console.WriteLine(foodQuantity);
                    }
                    else
                    {
                        break;
                    }


                }

                else
                {
                    break;
                }

            }
            if (qu.Count==0)
            {
                Console.WriteLine(biggest);
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine(biggest);
                qu.ToArray();
                Console.WriteLine($"Orders left: {string.Join(" ",qu)}");
            }
        }
    }
}
