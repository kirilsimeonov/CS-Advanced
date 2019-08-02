using System;


namespace DefiningClasses
{
    public class StartUp

    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Kiril";
            person.Age = 34;

            Person person2 = new Person("Misho", 35);
            Person person3 = new Person(33);

            Console.WriteLine($"Name:{person.Name} Age:{person.Age} ");
            Console.WriteLine($"Name:{person2.Name} Age:{person2.Age} ");
            Console.WriteLine($"Name:{person3.Name} Age:{person3.Age} ");

        }
    }
}
