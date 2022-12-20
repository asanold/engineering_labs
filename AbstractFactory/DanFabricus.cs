using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.AbstractFactory
{
    class DanFabricus : HFactory
    {
        public override Spell CreateSpell()
        {
            return new SCS();
        }

        public override Weapon CreateWeapon()
        {
            return new GP34();
        }
    }
}
