using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
    public class Mage : IEnemies
    {
        public string AttackDesc()
        {
            return "Attacks with the huge intellect of a mage";
        }

        public int AttackDamage()
        {
            return 40;
        }

        public int Health()
        {
            return 40;
        }

    }
}
