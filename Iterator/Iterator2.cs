using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Iterator
{
    class Iterator2 : IIterator
    {
        private readonly IAggregate _aggregate;
        private int _current = 0;
        public Iterator2(IAggregate aggregate)
        {
            this._aggregate = aggregate;
        }
        public object CurrentItem()
        {
            throw new NotImplementedException();
        }

        public bool hasNext()
        {
            return _current < _aggregate.Count;
        }

        public object Next()
        {
            _current += 4;
            return _aggregate[_current];
        }
    }
}
