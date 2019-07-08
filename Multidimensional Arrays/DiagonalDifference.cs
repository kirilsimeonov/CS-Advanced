using System;
using System.Linq;

namespace MultiArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            int sumFirst = 0;
            int sumSecond = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];
                    //Console.WriteLine(matrix[i,j]);

                }
            }

            //sumFirst += matrix[0, 0];
            //sumSecond += matrix[0, size - 1];
            //sumFirst += matrix[size - 1, size - 1];
            //sumSecond += matrix[size - 1, 0];
            for (int d = 0; d < size; d++)
            {
                sumFirst += matrix[d, d];
            }
            int temp = size - 1;
            for (int j = 0; j <size; j++)
            {


                sumSecond += matrix[j, temp];
                temp--;
            }
            //Console.WriteLine(sumFirst);
            //Console.WriteLine(sumSecond);
            Console.WriteLine($"{Math.Abs(sumFirst-sumSecond)}");

        }
    }
}
