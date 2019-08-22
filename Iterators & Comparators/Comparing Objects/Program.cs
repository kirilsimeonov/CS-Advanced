using System;
using System.Collections.Generic;

namespace ComparingObjects
{



    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();




            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "END")
                {
                    break;
                }



                people.Add(new Person(command[0], int.Parse(command[1]), command[2]));
            }




            int index = int.Parse(Console.ReadLine());
            if (index > people.Count - 1)
            {
                Console.WriteLine("No matches");
                return;
            }
            var personToCompare = people[index];

            int diffPerson = 0;
            int samePerson = 0;




            for (int i = 0; i < people.Count; i++)
            {

                if (personToCompare.CompareTo(people[i]) == 0)
                {

                    samePerson++;
                         }
                        else
                      {
                    diffPerson++;
                     }
            }





            if (samePerson > 0)
            {
                Console.WriteLine($"{samePerson} {diffPerson} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}