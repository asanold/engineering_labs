using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Iterator.Tree
{
    class Node : INode<int>
    {
        public int Value { get; set; }
        public INode<int> Parent { get; set; }
        public INode<int> Child { get; set; }
        public INode<int> Right { get; set; }
        public Node(int value)
        {
            this.Value = value;
        }
    }
}
