using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10
{
    public class BinarySearch
    {
        public bool BinarySearching<T>(T item, T[] array)
        {
            int first = 0;
            int last = array.Length - 1;
            int middle = last / 2;

            while (last >= first)
            {
                var compareResult = ((IComparable)(middle)).CompareTo(item);

                if (compareResult == 0)
                {
                    return true;
                }

                if(compareResult > 0)
                {
                    last = middle - 1;
                }
                else
                {
                    first = middle+1;
                }

                middle = first + ((last - first)/2); 
            }

            return false;
        }
    }
}
