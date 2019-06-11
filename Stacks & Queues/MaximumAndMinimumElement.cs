using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {

                var command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int task = command[0];

                if (task == 1)
                {
                    stack.Push(command[1]);
                }
                else if (task == 2 && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (task == 3 && stack.Count>0) 
                {
                    Console.WriteLine(stack.Max());
                }
                else if (task==4 && stack.Count>0)
                {
                    Console.WriteLine(stack.Min());
                }


            }
            stack.ToArray();
            Console.WriteLine(string.Join(", ",stack));

        }
    }
}
