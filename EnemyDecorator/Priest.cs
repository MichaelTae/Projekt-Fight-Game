﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
   public class Priest:EnemyDecorator
    {
        public Priest(IEnemies enemies) : base(enemies)
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

        public override int Health()
        {
            return Enemies.Health() + 95;
        }




    }
}
