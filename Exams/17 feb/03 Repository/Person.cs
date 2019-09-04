using System;
namespace Repository
{
    public class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthdate { get; set; }



        public Person(string name, int age, DateTime datetime)
        {
            Name = name;
            Age = age;
            Birthdate = datetime;
        }
    }
}
