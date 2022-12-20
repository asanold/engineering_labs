using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.AbstractFactory
{
    class BlackSaucerAttack : Spell
    {
        public override void Cast()
        {
            Console.WriteLine("Wooh Wooh Wooh, bzzzzzzzzzzziu");
        }
    }
}
