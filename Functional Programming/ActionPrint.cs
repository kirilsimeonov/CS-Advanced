using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = n => Console.WriteLine(n);

            string[] inputs = Console.ReadLine().Split();

            foreach (var input   in inputs)
            {

                print(input);
            }
        }
    }
}
