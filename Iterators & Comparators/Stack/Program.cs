using System;

namespace Stack
{
    class Program

    {
        static void Main(string[] args)
        {


            MyStack<string> collection = new MyStack<string>();




            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] line = input.Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
                string command = line[0];

                try
                {
                    if (command == "Push")
                    {
                        for (int i = 1; i < line.Length; i++)
                        {
                            collection.Push(line[i]);
                        }
                    }


                    else if (command == "Pop")
                    {
                        collection.Pop();
                    }
                }



                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}