using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
   public class Priest:EnemyDecorator
    {
        public Priest(Enemies enemies) : base(enemies)
        {

        }

        public override string AttackDesc()
        {
            return Enemies.AttackDesc() + "infused with holy power";
        }

        public override int AttackDamage()
        {
            return Enemies.AttackDamage() + 40;
        }

        public override int Head()
        {
            return 10;
        }

        public override int Torso()
        {
            return 30;
        }

        public override int Legs()
        {
            return 15;
        }


    }
}
