using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.AbstractFactory
{
    abstract class HFactory
    {
        public abstract Weapon CreateWeapon();
        public abstract Spell CreateSpell();
    }
}
