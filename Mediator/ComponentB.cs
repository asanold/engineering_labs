using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Mediator
{
    class ComponentB
    {
        Mediator m;

        public ComponentB(Mediator m)
        {
            this.m = m;
        }

        public void operationB()
        {
            m.notify(this);
        }
    }
}
