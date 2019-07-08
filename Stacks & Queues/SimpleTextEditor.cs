using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            StringBuilder text = new StringBuilder();
            Stack<string> sequence = new Stack<string>();
            //string text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                if (command == "1")
                {
                    sequence.Push(text.ToString());
                    text.Append(input[1]);


                }
                else if (command == "2")
                {
                    int index = int.Parse(input[1]);
                    sequence.Push(text.ToString());
                    text.Remove(text.Length - index,index);
                    
                }
                else if (command == "3")
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command == "4")

                {

                    text.Clear();
                    text.Append(sequence.Pop());

                }


            }


        }
    }
}
