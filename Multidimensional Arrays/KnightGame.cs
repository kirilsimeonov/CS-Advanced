using System;

namespace KnightB
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] board = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                string tokens = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = tokens[j];
                }
            }
            int maxCols = 0;
            int linKnightRow = -1;
            int linKnightCol = -1;

            int removed = 0;

            while (true)
            {
                maxCols = 0;
                linKnightRow = -1;
                linKnightCol = -1;

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (board[i, j] == 'K')
                        {
                            int knightCols = 0;
                            if (Valid(i - 2, j - 1, board) && board[i - 2, j - 1] == 'K')
                            {
                                knightCols++;
                            }


                            if (Valid(i - 2, j + 1, board) && board[i - 2, j + 1] == 'K')
                            {
                                knightCols++;
                            }
                           
                            if (Valid(i + 1, j - 2, board) && board[i + 1, j - 2] == 'K')
                            {
                                knightCols++;
                            }
                            if (Valid(i + 1, j + 2, board) && board[i + 1, j + 2] == 'K')
                            {
                                knightCols++;
                            }
                            if (Valid(i + 2, j - 1, board) && board[i + 2, j - 1] == 'K')
                            {
                                knightCols++;
                            }
                            if (Valid(i + 2, j + 1, board) && board[i + 2, j + 1] == 'K')
                            {
                                knightCols++;
                            }

                            if (Valid(i - 1, j - 2, board) && board[i - 1, j - 2] == 'K')
                            {
                                knightCols++;
                            }
                            if (Valid(i - 1, j + 2, board) && board[i - 1, j + 2] == 'K')
                            {
                                knightCols++;
                            }

                            if (knightCols > maxCols)
                            {
                                maxCols = knightCols;

                                linKnightCol = j;

                                linKnightRow = i;
                            }
                        }
                    }
                }



                if (maxCols == 0)

                {

                    break;
                }
                else
                {
                    board[linKnightRow, linKnightCol] = '0';


                    removed++;
                }

            }

            Console.WriteLine(removed);

         
        }
        static void Print(char[,] matrix)
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




        static bool Valid(int row, int coll, char[,] matrix)
        {
            if (row >= 0 && row < matrix.GetLength(0) && coll >= 0 && coll < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
