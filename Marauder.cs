using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
   public class Marauder: EnemyDecorator
    {

        public Marauder(Enemies enemies) : base(enemies)
        {

        }

        public override string AttackDesc()
        {
            return Enemies.AttackDesc() + "blabla";
        }

        public override int AttackDamage()
        {
            return Enemies.AttackDamage() + 50;
        }
        public override int Head()
        {
            return 30;
        }

        public override int Torso()
        {
            return 30;
        }

        public override int Legs()
        {
            return 40;
        }

    }
}
