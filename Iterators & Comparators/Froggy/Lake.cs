using System.Collections;
using System.Collections.Generic;
using System;

using System.Text;

namespace Froggy
{



    class Lake : IEnumerable<int>
    {
        private int[] internalArray;

        public Lake(int[] arr)
        {
            this.internalArray = arr;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LakeIterator(internalArray);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new LakeIterator(internalArray);
        }

       

        private class LakeIterator : IEnumerator<int>
        {
            private bool end = false;
            private int[] array;

            private int intIndex = -2;


            public int Current => array[intIndex];

            object IEnumerator.Current => array[intIndex];

            public LakeIterator(int[] arr)
            {
                this.Reset();
                this.array = arr;
            }

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                if (end == false)
                {
                    if (intIndex + 2 < array.Length)
                    {
                        intIndex += 2;
                        return true;
                    }
                    else
                    {


                        end = true;
                        if (intIndex + 1 < array.Length)
                        {
                            intIndex += 1;
                            return true;
                        }



                        else
                        {
                           

                             
                               if (intIndex - 1 >= 0)
                            {
                                intIndex -= 1;
                                return true;
                            }
                            else
                            {
                                return false;
                            }

                        }

                    }
                }



                else
                {
                    if (intIndex - 2 >= 1)
                    {
                        intIndex -= 2;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }



            public void Reset()
            {
                intIndex = -2;
            }
        }
    }
}