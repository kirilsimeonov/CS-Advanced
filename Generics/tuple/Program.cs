using System;
using System.Linq;

namespace Tuple
{
    public class StartUp
    {
        private static void Main()
        {


            string[] command1 = Console.ReadLine().Split().ToArray();
            string[] command2 = Console.ReadLine().Split().ToArray();
            string[] command3 = Console.ReadLine().Split().ToArray();



            var mix = new Tuple<string, string, string, string, int, int, double>
                (command1[0], command1[1], command1[2],
                command2[0], int.Parse(command2[1]),
                int.Parse(command3[0]), double.Parse(command3[1]));

            Console.WriteLine($"{mix.Item1} {mix.Item2} -> {mix.Item3}");
            Console.WriteLine($"{mix.Item4} -> {mix.Item5}");
            Console.WriteLine($"{mix.Item6} -> {mix.Item7}");
        }
    }
}