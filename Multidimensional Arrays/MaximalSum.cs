using System;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[input[0],input[1]];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    matrix[i, j] = numbers[j];
                    //Console.WriteLine(matrix[i,j]);
                }

            }
            int maxSum = int.MinValue;
            int selectedRow = 0;
            int selectedCol = 0;

            for (int z = 0; z < matrix.GetLength(0)-2; z++)
            {
                for (int d = 0; d < matrix.GetLength(1)-2; d++)
                {
                    int sum = matrix[z, d] + matrix[z + 1, d] + matrix[z + 2, d] +
                        matrix[z, d + 1] + matrix[z + 1, d + 1] + matrix[z + 2, d + 1] +
                        matrix[z, d + 2] + matrix[z + 1, d + 2] + matrix[z + 2, d + 2];

                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        selectedRow = z;
                        selectedCol = d;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[selectedRow,selectedCol]} {matrix[selectedRow, selectedCol+1]} {matrix[selectedRow, selectedCol+2]} ");
            Console.WriteLine($"{matrix[selectedRow+1, selectedCol]} {matrix[selectedRow+1, selectedCol + 1]} {matrix[selectedRow+1, selectedCol + 2]} ");
            Console.WriteLine($"{matrix[selectedRow+2, selectedCol]} {matrix[selectedRow+2, selectedCol + 1]} {matrix[selectedRow+2, selectedCol + 2]} ");


        }
    }
}
