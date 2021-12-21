using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
   public class Thief: EnemyDecorator
    {

        public Thief(Enemies enemies) : base(enemies)
        {

        }

        public override string AttackDesc()
        {
            return Enemies.AttackDesc() + "blabla";
        }

        public override int AttackDamage()
        {
            return Enemies.AttackDamage() + 35;
        }

        
        public override int Head()
        {
            return 10;
        }

        public override int Torso()
        {
            return 20;
        }

        public override int Legs()
        {
            return 30;
        }
    }
}
