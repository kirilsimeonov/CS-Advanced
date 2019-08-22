using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{


    public class ListyIterator<T> : IEnumerable<T>
    {



        public ListyIterator(params T[] data)
        {
            Data = data.ToList();
        }



        public int Index { get; set; } = 0;



        private List<T> Data { get; }

        public void Create(params T[] elements)
        {


            for (int i = 1; i < elements.Length; i++)
            {
               Data.Add(elements[i]);
            }
        }

       
        public bool HasNext()
        {
            return Index + 1 < this.Data.Count;
        }

        public bool Move()
        {
            if (HasNext())
            {


                Index++;
                return true;
            }

            else
            {
                return false;
            }

        }


        public void Print()
        {
            if (this.Data.Count != 0)
            {

                Console.WriteLine(this.Data[Index]);
            }

            else
            {
                Console.WriteLine($"Invalid Operation!");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
           

             
               for (int i = 0; i < this.Data.Count; i++)
            {

                yield return this.Data[i];

            }
        }


    }
}