using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Visitor
{
    class Boss
    {
        List<IElement> elements = new List<IElement>();
        public Boss(List<IElement> elements)
        {
            this.elements = new List<IElement>(elements);
        }

        public void Visit(IVisitor visitor)
        {
            foreach (var element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
