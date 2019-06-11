using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int toAdd = input[0];
            int toRemove = input[1];
            int present = input[2];
            Queue<int> qu = new Queue<int>();

            var command = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int c = 0; c < command.Length; c++)
            {
                qu.Enqueue(command[c]);
            }
            for (int i = 0; i < toRemove; i++)
            {
                if (qu.Count>=0)
                {
                    qu.Dequeue();
                }
            }
            if (qu.Contains(present))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (qu.Count>0)
                {
                    Console.WriteLine(qu.Min());
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
