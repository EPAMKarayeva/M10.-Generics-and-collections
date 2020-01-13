using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_4
{
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}
