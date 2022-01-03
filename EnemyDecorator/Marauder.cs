using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
   public class Marauder: EnemyDecorator
    {

        public Marauder(IEnemies enemies) : base(enemies)
        {

        }

        public override string AttackDesc()
        {
            return Enemies.AttackDesc() + "with the unyielding power of a marauder";
        }

        public override int AttackDamage()
        {
            return Enemies.AttackDamage() + 50;
        }
        public override int Health()
        {
            return Enemies.Health() + 120;
        }



    }
}
