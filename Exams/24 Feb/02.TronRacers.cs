using System;
using System.Collections.Generic;
using System.Linq;

namespace TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstPlayerRow = -1;
            int firstPlayerCol = -1;
            int secondPlayerRow = -1;
            int secondPlayerCol = -1;

            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)//FILL THE MATRIX
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int d = 0; d < n; d++)
                {
                    matrix[i, d] = input[d];
                    if (input[d]=='f')
                    {
                        firstPlayerRow = i;
                        firstPlayerCol = d;
                    }
                    else if (input[d]=='s')
                    {
                        secondPlayerRow = i;
                        secondPlayerCol = d;
                    }
                }
             }

            bool death = false;
            while (death==false)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firstCommand = input[0];
                string secondCommand = input[1];


                if (firstCommand == "left")
                {
                    if (firstPlayerCol - 1 < 0) firstPlayerCol = n - 1;
                    else firstPlayerCol -= 1;
                }
                else if (firstCommand == "right")
                {
                    if (firstPlayerCol + 1 > n-1) firstPlayerCol = 0;
                    else firstPlayerCol += 1;
                }
                else if (firstCommand == "up")
                {
                    if (firstPlayerRow - 1 < 0) firstPlayerRow = n - 1;
                    else firstPlayerRow -= 1;
                }
                else if (firstCommand == "down")
                {
                    if (firstPlayerRow + 1 > n-1) firstPlayerRow = 0;
                    else firstPlayerRow += 1;
                }

                if (matrix[firstPlayerRow,firstPlayerCol]!='s')
                {
                    matrix[firstPlayerRow, firstPlayerCol] = 'f';
                }
                else
                {
                    matrix[firstPlayerRow, firstPlayerCol] = 'x';
                    death = true;
                   // Console.WriteLine("First player dies");
                    break;
                }



                if (secondCommand == "left")
                {
                    if (secondPlayerCol - 1 < 0) secondPlayerCol = n - 1;
                    else secondPlayerCol -= 1;
                }
                else if (secondCommand == "right")
                {
                    if (secondPlayerCol + 1 > n - 1) secondPlayerCol = 0;
                    else secondPlayerCol += 1;
                }
                else if (secondCommand == "up")
                {
                    if (secondPlayerRow - 1 < 0) secondPlayerRow = n - 1;
                    else secondPlayerRow -= 1;
                }
                else if (secondCommand == "down")
                {
                    if (secondPlayerRow + 1 > n-1) secondPlayerRow = 0;
                    else secondPlayerRow += 1;
                }

                if (matrix[secondPlayerRow,secondPlayerCol] != 'f')
                {
                    matrix[secondPlayerRow, secondPlayerCol] = 's';
                }
                else
                {
                    matrix[secondPlayerRow, secondPlayerCol] = 'x';
                    death = true;
                   // Console.WriteLine($"Second player dies");
                    break;
                }

                //for (int z = 0; z < matrix.GetLength(0); z++)
                //{
                //    for (int j = 0; j < matrix.GetLength(1); j++)
                //    {
                //        Console.Write(matrix[z, j]);
                //    }
                //    Console.WriteLine();
                //}



                }
                for (int z = 0; z < matrix.GetLength(0); z++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[z, j]);
                }
                Console.WriteLine();


            }




        }
    }
}
