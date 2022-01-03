using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
    internal class Player : Character
    {
        public string UserClass()
        {
            return "Ranger";
        }

        public string Gender()
        {
            return "Male";
        }

        public int AttackDamage()
        {
            return 35;
        }

        public int Health()
        {
            return 200;
        }

        public string AttackDesc()
        {
            return "Dealing damage for ";
        }
    }
}