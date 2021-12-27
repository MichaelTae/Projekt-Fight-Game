using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
    public interface IWeaponBuilder
    {
        public IWeaponBuilder setHilt(string hilt);
        public IWeaponBuilder setBlade(string blade);
        public IWeaponBuilder setPommel(string pommel);
        public IWeaponBuilder setEnchantment(string enchantment);
        public IWeaponBuilder setSize(string size);
     

    }
}
