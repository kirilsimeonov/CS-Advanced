using System;
using System.Collections.Generic;
using System.Linq;


namespace HelensAbduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int parisRow = -1;
            int parisCol = -1;

            string input = Console.ReadLine();
            char[,] board = new char[n,input.Length];
            for (int i = 0; i < n; i++)
            {
                if (i!=0)
                {
                    input = Console.ReadLine();
                }
                for (int d = 0; d < input.Length; d++)
                {
                    board[i, d] = input[d];
                    if (board[i,d]=='P')
                    {
                        parisRow = i;
                        parisCol = d;
                    }
                }

            }

            bool helen = false;
            while (true)
            {

                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string direction = command[0];
                int spawnRow = int.Parse(command[1]);
                int spanwCol = int.Parse(command[2]);

                board[spawnRow, spanwCol] = 'S';

                if (direction=="up" && parisRow-1>=0)
                {
                    board[parisRow, parisCol] = '-';
                    parisRow--;
                    energy--;
                    if (board[parisRow, parisCol] == 'H')
                    {
                        helen = true;
                    }
                    else if (board[parisRow,parisCol]=='S')
                    {
                        energy -= 2;
                    }
                    board[parisRow, parisCol] = 'P';
                }
                else if (direction=="down" && parisRow+1<board.GetLength(0))
                {
                    board[parisRow, parisCol] = '-';
                    parisRow++;
                    energy--;
                    if (board[parisRow, parisCol] == 'H')
                    {
                        helen = true;
                    }
                    else if (board[parisRow, parisCol] == 'S')
                    {
                        energy -= 2;
                    }
                    board[parisRow, parisCol] = 'P';
                }
                else if (direction=="left" && parisCol-1>=0)
                {
                    board[parisRow, parisCol] = '-';
                    parisCol--;
                    energy--;
                    if (board[parisRow, parisCol] == 'H')
                    {
                        helen = true;
                    }
                    else if (board[parisRow, parisCol] == 'S')
                    {
                        energy -= 2;
                    }
                    board[parisRow, parisCol] = 'P';
                }
                else if (direction=="right" && parisCol+1<board.GetLength(1))
                {
                    board[parisRow, parisCol] = '-';
                    parisCol++;
                    energy--;
                    if (board[parisRow, parisCol] == 'H')
                    {
                        helen = true;
                    }
                    else if (board[parisRow, parisCol] == 'S')
                    {
                        energy -= 2;
                    }
                   
                    board[parisRow, parisCol] = 'P';
                }
                else
                {
                    energy--;
                }
               
                if (helen)
                {
                    board[parisRow, parisCol] = '-';
                    Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");

                    break;

                }
                if (energy<=0)
                {
                    board[parisRow, parisCol] = 'X';
                    Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                    break;

                }


                //for (int z = 0; z < board.GetLength(0); z++)
                //{
                //    for (int y = 0; y < board.GetLength(1); y++)
                //    {
                //        Console.Write(board[z, y]);
                //    }
                //    Console.WriteLine();
                //}


            }


            for (int z = 0; z < board.GetLength(0); z++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    Console.Write(board[z,y]);
                }
                Console.WriteLine();
            }
        }
    }
}
