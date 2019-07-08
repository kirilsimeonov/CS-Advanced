using System;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[input[0], input[1]];
            int counter = 0;


            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                string[] letters = Console.ReadLine().Split().ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = letters[j];
                    //Console.WriteLine(matrix[i,j]);

                }
            }
            for (int z = 0; z < matrix.GetLength(0) - 1; z++)
            {
                for (int d = 0; d < matrix.GetLength(1) - 1; d++)
                {
                    if (matrix[z, d] == matrix[z + 1, d] && matrix[z, d] == matrix[z, d + 1]
                    && matrix[z, d] == matrix[z + 1, d + 1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
