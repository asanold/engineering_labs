using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Iterator
{
    class Iterator1 : IIterator
    {
        private readonly IAggregate _aggregate;
        private int _current = 0;
        public Iterator1(IAggregate aggregate)
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
            object ret = null;
            ret = _aggregate[_current];
            _current += 1;
            return ret;
        }
    }
}
