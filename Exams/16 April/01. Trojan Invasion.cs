using System;
using System.Collections.Generic;
using System.Linq;

namespace TrojanInvasion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> plates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Stack<int> wave = new Stack<int>();
            int currentWarrior = 0;

            //            3
            //10 20 30

            //4 5 1
            //10 5 5
            //10 10 10
            //4 

            for (int i = 1; i <= n; i++)
            {

                wave = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse).ToArray());

                if (i % 3 == 0)
                {
                    //Console.WriteLine("add"); 
                    plates.Add(int.Parse(Console.ReadLine()));
                }

                while (wave.Count > 0)
                {

                    if (plates.Count == 0)
                    {
                        Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                        if (wave.Count > 0)
                        {
                            Console.WriteLine($"Warriors left: {string.Join(", ", wave)}");
                        }
                        return;
                    }
                    currentWarrior = wave.Peek();
                    int currentPlate = plates[0];
                    //Console.WriteLine($"current warrior {currentWarrior}");
                    //Console.WriteLine($"current plate {currentPlate}");

                    if (currentWarrior > currentPlate)
                    {
                        plates.RemoveAt(0);
                        currentWarrior -= currentPlate;
                        wave.Pop();
                        wave.Push(currentWarrior);
                    }
                    else if (currentWarrior <= currentPlate)
                    {

                        plates[0] = currentPlate-currentWarrior;
                        if (plates[0] == 0)
                        {
                            plates.RemoveAt(0);
                        }

                        wave.Pop();

                    }

                }


            }
            if (plates.Count == 0)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");

            }
            else
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
            }

            if (wave.Count > 0)
            {
                Console.WriteLine($"Warriors left: {string.Join(", ", wave)}");
            }
            if (plates.Count > 0)
            {
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            //foreach (var item in plates)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
        }
    }
}
