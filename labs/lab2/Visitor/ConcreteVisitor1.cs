using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Visitor
{
    class ConcreteVisitor1 : IVisitor
    {
        public void VisitA(ElementA element)
        {
            Console.WriteLine(element.GetType().Name + " " + element.Name);
        }

        public void VisitB(ElementB element)
        {
            Console.WriteLine(element.GetType().Name + " " + element.Name + " " + element.Smth);
        }
    }
}
