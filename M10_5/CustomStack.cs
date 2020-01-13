using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_5
{
    public class CustomStack : IAggregate
    {
        private List<object> items = new List<object>();

        public void Push(object obj)
        {
            items.Add(obj);
            var last = (int)items.Last();
            List<object> list = new List<object>();

            if (items.Count > 1)
            {
                items = Swap(items, obj);
            }
        }

        public object Pick()
        {
            var first = items.First();
            return first;
        }

        public object Pop()
        {
            var first = Pick();
            items.Remove(first);

            return first;
        }

        public static List<object> Swap(List<object> list, object obj) 
        {
            List<object> collection = new List<object>();
            collection.Add(obj);

            for (int i = 0; i < list.Count-1; i++)
            {
                collection.Add(list[i]);
            }

            return collection;
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public object this[int index]
        {
            get { return items[index]; }
        }

        public int Count
        {
            get { return items.Count; }
        }
    }
}
