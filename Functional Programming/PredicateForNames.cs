using System;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int wantedLegth = int.Parse(Console.ReadLine());


            Func<int, string, bool> lengthEvaluate = (count, name) => name.Length <= count;
            string[] names = Console.ReadLine().Split();


            foreach (string name in names)
            {
                if (lengthEvaluate(wantedLegth, name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
