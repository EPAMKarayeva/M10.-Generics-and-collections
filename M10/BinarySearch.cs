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
            int middle = 0;

            while (last >= first)
            {
                middle = (first+last)/2;
                T midValue = array[middle];

                var compareResult = ((IComparable)(midValue)).CompareTo(item);

                if (compareResult == 0)
                {
                    return true;
                }
                else if (compareResult >0)
                {
                    last = middle -1;
                }
                else
                {
                    first= middle + 1;
                }
            }

            return false;
        }
    }
}
