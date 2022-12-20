using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Iterator.Tree
{
    public abstract class TreeEnumerator<T> : IEnumerator<INode<T>>
    {
        protected INode<T> _Tree = null;

        protected INode<T> _Current = null;

        public TreeEnumerator(INode<T> tree)
        {
            _Tree = tree;
        }

        public INode<T> Current { get { return _Current; } }

        object System.Collections.IEnumerator.Current
        {
            get { return _Current; }
        }

        public abstract bool MoveNext();
        public abstract bool HasNext();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            _Current = null;
        }

        public virtual TreeEnumerator<T> GetEnumerator()
        {
            return this;
        }
    }
}
