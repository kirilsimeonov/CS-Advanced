using System;
using System.Linq;
using System.Collections.Generic;

namespace StackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bulletInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] locksInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int value = int.Parse(Console.ReadLine());

            Queue<int> locks = new Queue<int>(locksInput);
            Stack<int> bullets = new Stack<int>(bulletInput);
            int counter = 0;
            int bulletCount = 0;

            while (locks.Count!=0 && bullets.Count!=0)
            {

                int currentBullet = bullets.Pop();
                bulletCount++;
                int currentLock = locks.Peek();

                if (currentBullet>currentLock)
                {
                    Console.WriteLine("Ping!");
                    counter++;
                }
                else if (currentBullet<=currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                    counter++;
                }

                if (counter==barrelSize && bullets.Count>0)
                {
                    Console.WriteLine("Reloading!");
                    counter = 0;
                }


            }

            if (locks.Count==0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${value-(bulletCount*bulletPrice)}");
            }
            else if (bullets.Count==0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
