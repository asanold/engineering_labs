using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.AbstractFactory
{
    class AlienHollywoodF : HFactory
    {
        public override Spell CreateSpell()
        {
            return new BlackSaucerAttack();
        }

        public override Weapon CreateWeapon()
        {
            return new M4A1();
        }
    }
}
