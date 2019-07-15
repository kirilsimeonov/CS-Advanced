using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty_
{
    class Program
    {


        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split()
                .ToList();


            Predicate<string> predicate;




            while (true)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];
                if (command == "Party!")
                {
                    break;
                }
                string condition = input[1];
                string argument = input[2];




                predicate = Expression(condition, argument);

                if (command == "Double")
                {
                    var newGuests = guests.FindAll(predicate);
                    foreach (var guest in newGuests)
                    {
                        int indexOfGuest = guests.IndexOf(guest);
                        guests.Insert(indexOfGuest + 1, guest);
                    }
                }



                else if (command == "Remove")
                {
                    guests.RemoveAll(predicate);
                }


            }



            if (guests.Count > 0)
            {
                Console.WriteLine(string.Join(", ", guests) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }


        public static Predicate<string> Expression(string condition, string argument)
        {
            if (condition == "Length")
            {
                return p => p.Length == int.Parse(argument);
            }

            if (condition == "StartsWith")
            {
                return p => p.StartsWith(argument);
            }

            if (condition == "EndsWith")
            {
                return p => p.EndsWith(argument);
            }

           

            return null;
        }


    }
}
