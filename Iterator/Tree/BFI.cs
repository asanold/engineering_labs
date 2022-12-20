using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Iterator.Tree
{
    public class BFI<T> : TreeEnumerator<T>
    {
        Queue<INode<T>> q = new Queue<Tree.INode<T>>();


        public BFI(INode<T> tree) : base(tree) {
            q.Enqueue(tree);
        }

        public override bool MoveNext()
        {
            if (q.Count > 0)
            {
                _Current = q.Dequeue();

                if (_Current.Child != null) q.Enqueue(_Current.Child);
                if (_Current.Right != null) q.Enqueue(_Current.Right);
                //Console.WriteLine(q.Count);
                return true;
            }
            return false;
        }
        
        public override bool HasNext()
        {
            if (q.Count > 0) return true;
            else return false;
        }
    }
}
