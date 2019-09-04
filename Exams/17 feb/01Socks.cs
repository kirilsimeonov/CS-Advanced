using System;
using System.Collections.Generic;
using System.Linq;

namespace Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lefts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] rights = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> pairs = new List<int>();

            Stack<int> leftSocks = new Stack<int>(lefts);
            Queue<int> rightSocks = new Queue<int>(rights);

            while (leftSocks.Count!=0 && rightSocks.Count!=0)
            {



                int left = leftSocks.Peek();
                int right = rightSocks.Peek();

                if (left == right)
                {
                    leftSocks.Pop();
                    rightSocks.Dequeue();
                    leftSocks.Push(left + 1);
                }
                else if (left < right)
                {
                    leftSocks.Pop();
                }
                else if (left > right)
                {
                    pairs.Add(left + right);
                    leftSocks.Pop();
                    rightSocks.Dequeue();
                }
            }
            int highest = pairs.OrderByDescending(x => x).FirstOrDefault();
            Console.WriteLine(highest);
            Console.WriteLine(string.Join(" ",pairs));
        }
    }
}
