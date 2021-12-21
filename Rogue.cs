using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
    public class Rogue: EnemyDecorator
    {

        public Rogue(Enemies enemies) : base(enemies)
        {

        }


        public override string AttackDesc()
        {
            return Enemies.AttackDesc() + "with the added benefit of tricky a rogue";
        }

        public override int AttackDamage()
        {
            return Enemies.AttackDamage() + 40;
        }

        public override int Head()
        {
            return 20;
        }

        public override int Torso()
        {
            return 20;
        }

        public override int Legs()
        {
            return 20;
        }
    }
}
