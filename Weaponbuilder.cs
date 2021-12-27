using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
    public class Weaponbuilder : IWeaponBuilder
    {
        private Weapon _weapon = new Weapon();

        public IWeaponBuilder setPommel(string pommel)
        {
            _weapon.Pommel = pommel;
            return this;

        }

        public IWeaponBuilder setHilt(string hilt)
        {
            _weapon.Hilt = hilt;
            return this;

        }

        public IWeaponBuilder setBlade(string blade)
        {
            _weapon.Blade = blade;
            return this;

        }

        public IWeaponBuilder setSize(string size)
        {
            _weapon.Size = size;
            return this;

        }

        public IWeaponBuilder setEnchantment(string enchantment)
        {
            _weapon.Enchantment = enchantment;
            return this;

        }


        public Weapon build() => _weapon;

    }
}
