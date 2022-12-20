using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Iterator
{
    interface IAggregate
    {
        IIterator CreateIterator<T>() where T : IIterator;
        int Count { get;  }
        object this[int index] { get; }
    }
}
