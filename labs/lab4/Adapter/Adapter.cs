using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Adapter
{
    class Adapter : IClient
    {
        Service adaptee;
        public Adapter(Service adaptee)
        {
            this.adaptee = adaptee;
        }

        public void method(string data)
        {
            adaptee.serviceMethod(data);
        }
    }
}
