using System;
using System.Collections.Generic;
using System.Linq;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalFuel = 0;
            int counter = 0;

            Queue<string> qu = new Queue<string>();
           
            for (int d = 0; d < n; d++)
            {
                qu.Enqueue(Console.ReadLine());
            }


            int index = 0;

            while (true)
            {

                foreach (var item in qu)
                {

                    var input = item.Split().Select(int.Parse).ToArray();
                    int pump = input[0];
                    //Console.WriteLine($"pump {pump}");

                    int distance = input[1];
                    //Console.WriteLine($"distance {distance}");

                    totalFuel += pump;

                    //Console.WriteLine($"total fuel {totalFuel}");
                    if (totalFuel >= distance)
                    {
                        totalFuel -= distance;

                        counter++;
                        //Console.WriteLine($"counter {counter}");
                        if (counter == qu.Count - 1)
                        {
                            Console.WriteLine(index);
                            return;
                        }
                    }
                    else
                    {
                        qu.Enqueue(qu.Dequeue());
                        index++;
                        totalFuel = 0;
                        break;
                    }


                }

                counter = 0;
                //Console.ReadLine();
            }

        }
    }
}
