using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_4
{
    public class CustomQueue : IAggregate
    {
        private List<object> items = new List<object>();

        public void Add(object o)
        {
            items.Add(o);
        }

        public object PickFirstQue()
        {
            var first = items.First();
            return first;
        }

        public object DeleteFromQue()
        {
            var first = PickFirstQue();
            items.Remove(first);

            return first;
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
