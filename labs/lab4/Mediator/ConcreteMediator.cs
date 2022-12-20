using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Mediator
{
    class ConcreteMediator : Mediator
    {
        public ComponentA ca { get; set; }
        public ComponentB cb { get; set; }
        public void notify(object sender)
        {
            if (ca.Equals(sender))
            {
                reactOnA();
            }
            else if (cb.Equals(sender))
            {
                reactOnB();
            }
        }

        private void reactOnA()
        {
            Console.WriteLine("reactOnA");
        }
        private void reactOnB()
        {
            Console.WriteLine("reactOnB");
        }
    }
}
