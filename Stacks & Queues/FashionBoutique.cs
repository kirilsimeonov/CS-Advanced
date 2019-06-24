using System;
using System.Collections.Generic;
using System.Linq;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int current = capacity;
            Stack<int> stack = new Stack<int>(clothes);
            //Console.WriteLine(stack.Count);
            int counter = 1;

            while (stack.Count>0)
            {

                if (current >= stack.Peek()) 
                {
                    current -= stack.Pop();
                    //Console.WriteLine($"Current: {current}");
                    //Console.WriteLine($"Last stack {stack.Peek()}");


                }
                else if (current<stack.Peek())
                {
                    current = capacity;
                    counter++;
                    //Console.WriteLine($"counter {counter}");
                }
            }
            Console.WriteLine(counter);

        }
    }
}
