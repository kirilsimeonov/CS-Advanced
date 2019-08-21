using System;
using System.Linq;

namespace Threeuple
{
    public class StartUp
    {


        private static void Main()
        {


            string[] input1 = Console.ReadLine().Split().ToArray();
            string[] input2 = Console.ReadLine().Split().ToArray(); 
            string[] input3 = Console.ReadLine().Split().ToArray(); 

            var mixOne = new Tuple<string, string, string>(input1[0] + " " + input1[1], input1[2], input1[3]);

            var mixTwo = new Tuple<string, int, string>(input2[0], int.Parse(input2[1]), input2[2] == "drunk" ? "True" : "False");

            var mixThree = new Tuple<string, double, string>(input3[0], double.Parse(input3[1]), input3[2]);

            Console.WriteLine($"{mixOne.Item1} -> {mixOne.Item2} -> {mixOne.Item3}");
            Console.WriteLine($"{mixTwo.Item1} -> {mixTwo.Item2} -> {mixTwo.Item3}");
            Console.WriteLine($"{mixThree.Item1} -> {mixThree.Item2} -> {mixThree.Item3}");
        }
    }
}