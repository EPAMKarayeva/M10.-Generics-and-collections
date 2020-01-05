using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_4
{
    public static class CustomQueue
    {        
        public static void AddToQue<T>(this List<T> list, T item)
        {
            list.Add(item);
        }

        public static T PickFirstQue<T>(this List<T> list)
        {
            var first = list.First();
            return first;
        }
    }
}
