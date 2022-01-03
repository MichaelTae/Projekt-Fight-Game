using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
    public interface IEnemies
    {

        public string AttackDesc();

        public int AttackDamage();

        public int Health();

    }
}
