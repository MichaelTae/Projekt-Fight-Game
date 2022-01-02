using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
   public class Thief: EnemyDecorator
    {

        public Thief(IEnemies enemies) : base(enemies)
        {

        }

        public override string AttackDesc()
        {
            return Enemies.AttackDesc() + "empowered with the thiefs streetsmart intellect";
        }

        public override int AttackDamage()
        {
            return Enemies.AttackDamage() + 35;
        }

        
        public override int Health()
        {
            return 100;
        }


    }
}
