using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
   public  class CurrentEnemy
    {

        public int AttackDamage { get; set; }
        public int Health { get; set; }
        public string AttackDesc { get; set; }


        public CurrentEnemy(int attackDamage, int health, string attackDesc)
        {
            AttackDesc = attackDesc;
            AttackDamage = attackDamage;
            Health = health;
        }

        



        
    }
}
