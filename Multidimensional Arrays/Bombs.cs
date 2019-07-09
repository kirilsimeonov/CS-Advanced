using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int alive = 0;
            int sum = 0;

            for (int row = 0; row < n; row++)
            {
                List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            List<string> coordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int bombRow = -1;
            int bombCol = -1;

            for (int i = 0; i < coordinates.Count; i++)
            {

                int[] currentCoordinates = coordinates[i].Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                bombRow = currentCoordinates[0];
                bombCol = currentCoordinates[1];
                int bombValue = matrix[bombRow, bombCol];


                if (bombValue>0)
                {


                    matrix[bombRow, bombCol] = 0;
                    if (bombRow > 0)
                    {
                        if (matrix[bombRow - 1, bombCol] > 0)
                            matrix[bombRow - 1, bombCol] -= bombValue;
                    
                    }
                    if (bombRow < matrix.GetLength(0) - 1)
                    {
                        if (matrix[bombRow + 1, bombCol]>0)
                        {
                            matrix[bombRow + 1, bombCol] -= bombValue;
                        }
                       
                    }
                    if (bombCol > 0)
                    {
                        if (matrix[bombRow, bombCol - 1]>0)
                        {
                            matrix[bombRow, bombCol - 1] -= bombValue;
                        }

                    }
                    if (bombCol < matrix.GetLength(1) - 1)
                    {
                        if (matrix[bombRow, bombCol + 1]>0)
                        {
                            matrix[bombRow, bombCol + 1] -= bombValue;
                        }

                    }
                    if (bombRow > 0 && bombCol > 0)
                    {
                        if (matrix[bombRow - 1, bombCol - 1]>0)
                        {
                            matrix[bombRow - 1, bombCol - 1] -= bombValue;
                        }

                    }
                    if (bombRow < matrix.GetLength(0)-1 && bombCol < matrix.GetLength(1)-1)
                    {
                        if (matrix[bombRow + 1, bombCol + 1]>0)
                        {
                            matrix[bombRow + 1, bombCol + 1] -= bombValue;
                        }

                    }
                    if (bombRow < matrix.GetLength(0)-1 && bombCol > 0)
                    {
                        if (matrix[bombRow + 1, bombCol - 1]>0)
                        {
                            matrix[bombRow + 1, bombCol - 1] -= bombValue;
                        }

                    }
                    if (bombRow > 0 && bombCol < matrix.GetLength(1)-1)
                    {
                        if (matrix[bombRow - 1, bombCol + 1]>0)
                        {
                            matrix[bombRow - 1, bombCol + 1] -= bombValue;
                        }

                    }

                }





            }
            for (int z = 0; z < matrix.GetLength(0); z++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[z, j] > 0)
                    {
                        alive++;
                        sum += matrix[z, j];
                    }

                }

            }
            Console.WriteLine($"Alive cells: {alive}");
            Console.WriteLine($"Sum: {sum}");
            for (int z = 0; z < matrix.GetLength(0); z++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write(matrix[z, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
