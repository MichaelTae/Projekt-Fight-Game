using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
    public abstract class CharacterDecorator : Character
    {
        public Character Character;

        protected CharacterDecorator(Character character)
        {
            Character = character;
        }

        public abstract string UserClass();
        public abstract string Gender();
        public abstract string AttackDesc();

        public abstract int AttackDamage();

        public abstract int Health();

    }
}
