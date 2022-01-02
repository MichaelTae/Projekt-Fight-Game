using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
    public class Rogue: EnemyDecorator
    {

        public Rogue(IEnemies enemies) : base(enemies)
        {

        }


        public override string AttackDesc()
        {
            return Enemies.AttackDesc() + "with the added benefit of a tricky rogue";
        }

        public override int AttackDamage()
        {
            return Enemies.AttackDamage() + 40;
        }

        public override int Health()
        {
            return 105;
        }


    }
}
