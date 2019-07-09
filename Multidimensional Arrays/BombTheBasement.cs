using System;
using System.Linq;

namespace Bomb_the_Basement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            int[] prop = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];
            int tRow = prop[0];
            int tCol = prop[1];
            int radius = prop[2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int dimX = Math.Abs(tRow - i);
                    int dimY = Math.Abs(tCol - j);

                    if (dimX + dimY <= radius)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }

            //PrintMatrix(matrix);
            //Console.WriteLine();

            for (int j = Math.Max((tCol - radius), 0); j < Math.Min(matrix.GetLength(1), (tCol + radius + 1)); j++)
            {
                while (matrix[0, j] < 1)
                {
                    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                    {
                        matrix[i, j] = matrix[i + 1, j];
                    }
                    matrix[matrix.GetLength(0) - 1, j] = 0;
                }
            }



            PrintMatrix(matrix);
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}

