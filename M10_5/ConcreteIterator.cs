using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_5
{
    class ConcreteIterator : IIterator
    {
        private CustomStack aggregate;
        int index;

        public ConcreteIterator(CustomStack aggregate)
        {
            this.aggregate = aggregate;
            index = -1;
        }

        public bool Next()
        {
            index++;
            return index < aggregate.Count;
        }

        public object Current
        {
            get
            {
                if (index < aggregate.Count)
                {
                    return aggregate[index];
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
