using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp

    {
        static void Main(string[] args)
        {

            string day1 = Console.ReadLine();
            string day2 = Console.ReadLine();

            DateModifier date = new DateModifier(day1, day2);
            Console.WriteLine(date.Calculate());









            //int n = int.Parse(Console.ReadLine());
            //Family family = new Family();
            //for (int i = 0; i< n; i++)
            //{
            //    var input = Console.ReadLine().Split().ToArray();
            //    string name = input[0];
            //    int age = int.Parse(input[1]);
            //    var membo = new Person(input[0], age);
            //    family.AddMember(membo);
            //}

            //List<Person> older = new List<Person>();
            //older = family.OlderThan30();
            //foreach (var item in older)
            //{
            //    Console.WriteLine($"{item.Name} - {item.Age}");
            //}

            //Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
            //foreach (var item in family.Members)
            //{ 
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Age);
            //}

        }
    }
}
