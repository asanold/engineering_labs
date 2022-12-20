using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Iterator
{
    class Aggregate_C1 : IAggregate
    {
        private int[] _array;
        public Aggregate_C1(int[] array)
        {
            this._array = array;
        }

        public object this[int index]
        {
            get { return _array[index]; }
        }

        public int Count
        {
            get { return _array.Length; }
        }

        public IIterator CreateIterator<T>() where T : IIterator
        {
            return (T)Activator.CreateInstance(typeof(T), this);
        }
    }
}
