using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adapter
            Adapter.Adapter adapt = new Adapter.Adapter(new Adapter.Service());
            adapt.method("data");



            //Mediator
            Mediator.ConcreteMediator cm = new Mediator.ConcreteMediator();

            Mediator.ComponentA ca = new Mediator.ComponentA(cm);
            Mediator.ComponentB cb = new Mediator.ComponentB(cm);

            cm.ca = ca;
            cm.cb = cb;

            ca.operationA();
            cb.operationB();

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
