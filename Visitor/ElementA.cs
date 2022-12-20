using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Visitor
{
    class ElementA : IElement
    {
        public string Name { get; private set; }

        public ElementA(string name)
        {
            this.Name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitA(this);
        }
    }
}
