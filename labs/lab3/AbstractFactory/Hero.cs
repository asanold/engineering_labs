using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.AbstractFactory
{
    class Hero
    {
        private Weapon _weapon;
        private Spell _spell;
        public Hero(HFactory factory)
        {
            _weapon = factory.CreateWeapon();
            _spell = factory.CreateSpell();
        }

        public void Shoot()
        {
            _weapon.Shot();
        }
        public void Cast()
        {
            _spell.Cast();
        }
    }
}
