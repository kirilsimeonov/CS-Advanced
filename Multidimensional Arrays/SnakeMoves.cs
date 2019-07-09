using System;
using System.Linq;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[input[0], input[1]];

            char[] snake = Console.ReadLine().ToCharArray();
            //Console.WriteLine(string.Join(" ",snake));
            int index = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {



                for (int j = 0; j < matrix.GetLength(1); j++)
                {


                    matrix[i, j] = snake[index].ToString();

                    Console.Write(matrix[i,j]);

                    if (index==snake.Length-1)
                    {
                        index = -1;
                    }
                    index++;
                }
                Console.WriteLine();
            }


        }
    }
}
