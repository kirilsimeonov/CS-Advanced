using System;
using System.Linq;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[input[0], input[1]];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    matrix[i, j] = numbers[j];
                    //Console.WriteLine(matrix[i,j]);
                }

            }

            string command = Console.ReadLine();

            while (command.ToLower()!="end")
            {

                string[] inputCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string task = inputCommand[0];
                if (task!="swap" || inputCommand.Length!=5 )
                {
                    Console.WriteLine("Invalid input!");
                }
                else if (int.Parse(inputCommand[1])<0 || int.Parse(inputCommand[1])>matrix.GetLength(0)
                || int.Parse(inputCommand[3]) < 0 || int.Parse(inputCommand[3]) > matrix.GetLength(0)
                    || int.Parse(inputCommand[2]) < 0 || int.Parse(inputCommand[2]) > matrix.GetLength(1)
                || int.Parse(inputCommand[4]) < 0 || int.Parse(inputCommand[4]) > matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int row1 = int.Parse(inputCommand[1]);
                    int col1 = int.Parse(inputCommand[2]);
                    int row2 = int.Parse(inputCommand[3]);
                    int col2 = int.Parse(inputCommand[4]);

                    string temp1 = matrix[row1, col1];
                    string temp2 = matrix[row2, col2];
                    matrix[row1, col1] = temp2;
                    matrix[row2, col2] = temp1;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int d = 0; d < matrix.GetLength(1); d++)
                        {
                            Console.Write(matrix[i, d] + " ");
                        }
                        Console.WriteLine();
                    }
                }





                command = Console.ReadLine();
            }
        }
    }
}
