using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Mediator
{
    class ComponentA
    {
        Mediator m;

        public ComponentA(Mediator m)
        {
            this.m = m;
        }

        public void operationA()
        {
            m.notify(this);
        }
    }
}
