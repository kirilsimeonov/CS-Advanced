using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SpaceStationRecruitment
{
    public class SpaceStation
    {

        public string Name { get; set; }
        public int Capacity { get; set; }
        private List<Astronaut> data;

        public int Count { get {
                return data.Count();
        } }

        public SpaceStation(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Astronaut>();
        }

        public void Add(Astronaut astrounaut)
        {
            if (data.Count<Capacity)
            {
                data.Add(astrounaut);
            }
        }
        public bool Remove(string name)
        {
            if (data.Any(x=>x.Name==name))
            {
                var current = data.Where(x => x.Name == name).FirstOrDefault();
                data.Remove(current);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Astronaut GetOldestAstronaut()
        {
            var oldest = data.OrderByDescending(x => x.Age).FirstOrDefault();
                return oldest;
        }
        public Astronaut GetAstronaut (string name)
        {
            var current = data.Where(x => x.Name == name).FirstOrDefault();
            return current;
        }
        public string Report ()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Astronauts working at Space Station {Name}:");
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();

        }

    }
}
