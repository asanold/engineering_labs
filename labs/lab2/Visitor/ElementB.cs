using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Visitor
{
    class ElementB : IElement
    {
        public string Name { get; private set; }
        public string Smth { get; }

        public ElementB(string name, string smth)
        {
            this.Name = name;
            this.Smth = smth;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitB(this);
        }
    }
}
