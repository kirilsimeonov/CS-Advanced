using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }
        public void AddMember(Person member)
        {
            members.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = members.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestPerson;
        }
        public List<Person> OlderThan30()
        {
             
            List<Person> older = members.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
            return older;

        }
    }
}
