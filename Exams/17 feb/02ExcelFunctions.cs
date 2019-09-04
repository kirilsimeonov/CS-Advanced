using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace excelfunctions
{
    public class Program
    {


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[,] table = new string[n, input.Length];
            int[,] random = new int[3, 3];

            for (int i = 0; i < n; i++)
            {
                if (i != 0)
                {
                    input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                }
                for (int d = 0; d < input.Length; d++)
                {
                    table[i, d] = input[d];
                }
            }
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string task = command[0];
            string header = command[1];
            StringBuilder tableBuilder = new StringBuilder();

            if (task == "hide")
            {
                int hideCol = -1;
                for (int z = 0; z < table.GetLength(1); z++)
                {
                    if (table[0, z] == header)
                    {
                        hideCol = z;
                    }
                }


                for (int i = 0; i < table.GetLength(0); i++)
                {
                    List<string> line = new List<string>();
                    for (int z = 0; z < table.GetLength(1); z++)
                    {

                        if (z == hideCol)
                        {
                            continue;
                        }
                        else {

                            line.Add(table[i, z]);
                        }

                    }
                    tableBuilder.AppendLine(string.Join(" | ", line));

                }
                //Console.WriteLine(tableBuilder.ToString().Trim());


            }
            if (task == "sort")
            {


                int sortCol = -1;
                List<string> line = new List<string>();
                
                for (int z = 0; z < table.GetLength(1); z++)
                {
                    line.Add(table[0, z]); //add header
                    if (table[0, z] == header)
                    {

                        sortCol = z;
                    }
                }
                tableBuilder.AppendLine(string.Join(" | ", line));
                line.Clear();

                List<string> colElements = new List<string>();
                for (int i = 1; i < table.GetLength(0); i++)
                {
                    colElements.Add(table[i, sortCol]);
                }
                var sorted = colElements.OrderBy(x => x).ToList();

                //Console.WriteLine(string.Join(" ",sorted));

                for (int d = 0; d < sorted.Count(); d++)
                {
                    for (int i = 1; i < table.GetLength(0); i++)
                    {

                            if (table[i, sortCol] == sorted[d])
                            {
                                for (int j = 0; j < table.GetLength(1); j++)
                                {

                                    line.Add(table[i, j]);
                                    //Console.WriteLine("added "+table[i,j]);


                                }
                                tableBuilder.AppendLine(string.Join(" | ", line));
                                line.Clear();
                            }
                        }
                    }


            }
            if (task=="filter")
            {
                string value = command[2];
                int sortCol = -1;
                List<string> line = new List<string>();

                for (int z = 0; z < table.GetLength(1); z++)
                {
                    line.Add(table[0, z]); //add header
                    if (table[0, z] == header)
                    {

                        sortCol = z;
                    }
                }
                tableBuilder.AppendLine(string.Join(" | ", line));
                line.Clear();


                for (int i = 0; i < table.GetLength(0); i++)
                {
                    if (table[i, sortCol] == value)
                    {
                        for (int j = 0; j < table.GetLength(1); j++)
                        {

                            line.Add(table[i, j]);
                            //Console.WriteLine("added "+table[i,j]);
                        }
                        tableBuilder.AppendLine(string.Join(" | ", line));
                        line.Clear();
                    }
                }
          }
            Console.WriteLine(tableBuilder.ToString().Trim());
        }
    }
}
