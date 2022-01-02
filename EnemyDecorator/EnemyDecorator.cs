using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
    public abstract class EnemyDecorator : IEnemies
    {

        public IEnemies Enemies;

        protected EnemyDecorator(IEnemies enemies)
        {
            Enemies = enemies;
        }

        public abstract string AttackDesc();

        public abstract int AttackDamage();

        public abstract int Health();




    }
}
