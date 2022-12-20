using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Visitor
{
    interface IVisitor
    {
        void VisitA(ElementA element);
        void VisitB(ElementB element);
    }
}
