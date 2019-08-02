using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp

    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i< n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                var membo = new Person(input[0], age);
                family.AddMember(membo);
            }
            Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
            //foreach (var item in family.Members)
            //{ 
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Age);
            //}

        }
    }
}
