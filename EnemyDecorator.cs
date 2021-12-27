using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
    public abstract class EnemyDecorator : Enemies
    {

        public Enemies Enemies;

        protected EnemyDecorator(Enemies enemies)
        {
            Enemies = enemies;
        }

        public abstract string AttackDesc();

        public abstract int AttackDamage();

        public abstract int Health();




    }
}
