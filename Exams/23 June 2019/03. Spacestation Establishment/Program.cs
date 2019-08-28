using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int stephenRow = -1;
            int stephenCol = -1;
            bool lost = false;
            int starPower = 0;
            List<string> blackHoles = new List<string>();

            for (int rows = 0; rows < n; rows++)
            {
                string input = Console.ReadLine();

                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows,cols] = input[cols];
                    if (matrix[rows,cols]=='S')
                    {
                        stephenRow = rows;
                        stephenCol = cols;
                    }
                    if (matrix[rows,cols]=='O')
                    {
                        blackHoles.Add($"{rows} {cols}");
                    }
                }
            }




            while (starPower<50)
            {
                string command=Console.ReadLine();


                if (command=="left")
                {
                    if (stephenCol-1<0)
                    {
                        matrix[stephenRow, stephenCol] = '-';
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        break;
                    }
                    else
                    {
                        matrix[stephenRow, stephenCol] = '-';
                        stephenCol--;
                        if (char.IsDigit(matrix[stephenRow,stephenCol]))
                        {
                            int currentDigit = int.Parse(matrix[stephenRow, stephenCol].ToString());
                            starPower += currentDigit;
                            matrix[stephenRow, stephenCol] = 'S';
                        }
                        else if (matrix[stephenRow,stephenCol]=='O')
                        {
                            blackHoles.Remove($"{stephenRow} {stephenCol}");
                            matrix[stephenRow, stephenCol] = '-';
                            int[] blackHoleLocation = blackHoles[0].Split(" ").Select(int.Parse).ToArray();
                            stephenRow = blackHoleLocation[0];
                            stephenCol = blackHoleLocation[1];
                            matrix[stephenRow, stephenCol] = 'S';
                        }

                    }
                }
                if (command == "right")
                {
                    if (stephenCol + 1 > matrix.GetLength(1)-1)
                    {
                        matrix[stephenRow, stephenCol] = '-';
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        break;
                    }
                    else
                    {
                        matrix[stephenRow, stephenCol] = '-';
                        stephenCol++;
                        if (char.IsDigit(matrix[stephenRow, stephenCol]))
                        {
                            int currentDigit = int.Parse(matrix[stephenRow, stephenCol].ToString());
                            starPower += currentDigit;
                            matrix[stephenRow, stephenCol] = 'S';
                        }
                        else if (matrix[stephenRow, stephenCol] == 'O')
                        {
                            blackHoles.Remove($"{stephenRow} {stephenCol}");
                            matrix[stephenRow, stephenCol] = '-';
                            int[] blackHoleLocation = blackHoles[0].Split(" ").Select(int.Parse).ToArray();
                            stephenRow = blackHoleLocation[0];
                            stephenCol = blackHoleLocation[1];
                            matrix[stephenRow, stephenCol] = 'S';
                        }

                    }
                }
                if (command == "down")
                {
                    if (stephenRow + 1 > matrix.GetLength(0)-1)
                    {
                        matrix[stephenRow, stephenCol] = '-';
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        break;
                    }
                    else
                    {
                        matrix[stephenRow, stephenCol] = '-';
                        stephenRow++;
                        if (char.IsDigit(matrix[stephenRow, stephenCol]))
                        {
                            int currentDigit = int.Parse(matrix[stephenRow, stephenCol].ToString());
                            starPower += currentDigit;
                            matrix[stephenRow, stephenCol] = 'S';
                        }
                        if (matrix[stephenRow, stephenCol] == 'O')
                        {
                            blackHoles.Remove($"{stephenRow} {stephenCol}");
                            matrix[stephenRow, stephenCol] = '-';
                            int[] blackHoleLocation = blackHoles[0].Split(" ").Select(int.Parse).ToArray();
                            stephenRow = blackHoleLocation[0];
                            stephenCol = blackHoleLocation[1];
                            matrix[stephenRow, stephenCol] = 'S';
                        }

                    }
                }
                if (command == "up")
                {
                    if (stephenRow - 1 < 0)
                    {
                        matrix[stephenRow, stephenCol] = '-';
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        break;
                    }
                    else
                    {
                        matrix[stephenRow, stephenCol] = '-';
                        stephenRow--;
                        if (char.IsDigit(matrix[stephenRow, stephenCol]))
                        {
                            int currentDigit = int.Parse(matrix[stephenRow, stephenCol].ToString());
                            starPower += currentDigit;
                            matrix[stephenRow, stephenCol] = 'S';
                        }
                        if (matrix[stephenRow, stephenCol] == 'O')
                        {
                            blackHoles.Remove($"{stephenRow} {stephenCol}");
                            matrix[stephenRow, stephenCol] = '-';
                            int[] blackHoleLocation = blackHoles[0].Split(" ").Select(int.Parse).ToArray();
                            stephenRow = blackHoleLocation[0];
                            stephenCol = blackHoleLocation[1];
                            matrix[stephenRow, stephenCol] = 'S';
                        }

                    }
                }





            }/////
            if (starPower>=50)
            {
                Console.WriteLine($"Good news! Stephen succeeded in collecting enough star power!");
            }
            Console.WriteLine($"Star power collected: {starPower}");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
