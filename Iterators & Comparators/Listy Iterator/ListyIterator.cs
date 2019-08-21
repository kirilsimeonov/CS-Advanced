using System.Collections;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ListyIterator
{





    public class ListyIterator<T>
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
                this.Data.Add(elements[i]);
            }
        }


        public void Print()
        {
            if (Data.Count != 0)
            {
               

                  Console.WriteLine(Data[Index]);
            }
            else
            {
                Console.WriteLine($"Invalid Operation!");
            }
        }
        public bool Move()
        {
            if (Next())
            {


                Index++;
                return true;
            }

            else
            {
                return false;
            }

        }



        public bool Next()
        {
            return Index + 1 < this.Data.Count;
        }

       
    }
}