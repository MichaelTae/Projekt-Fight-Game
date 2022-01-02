using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
   public class Warrior:IEnemies
    {
        public string AttackDesc()
        {
            return "Attacks with the raw strength of a warrior";
        }

        public int AttackDamage()
        {
            return 20;
        }

    }
}
