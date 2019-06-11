using System;
using System.Linq;
using System.Collections.Generic;

namespace StacksExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().
            Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();


            int push = input[0];
            int pop = input[1];
            int cont = input[2];

            var integers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < integers.Length; i++)
            {
                stack.Push(integers[i]);
            }
            for (int d = 0; d < pop; d++)
            {

                                stack.Pop();
            }
            if (stack.Contains(cont))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count>0)
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine("0");
                }

            }

        }
    }
}
