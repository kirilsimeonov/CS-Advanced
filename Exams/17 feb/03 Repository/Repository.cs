using System;
using System.Linq;
using System.Collections.Generic;

namespace Repository
{
    public class Repository
    {

        private List<Person> data;

        public int Count
        {
            get
            { return data.Count(); }
        }

        public Repository()
        {
            data = new List<Person>();
        }
        public void Add (Person person)
        {
            data.Add(person);
         }
        public Person Get (int id)
        {
            return data[id];
        }
        public bool Update (int id, Person newperson)
        {
            if (data.Count>id)
            {

                data[id] = newperson;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete (int id)
        {
            if (data.Count>id)
            {
                data.RemoveAt(id);
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

