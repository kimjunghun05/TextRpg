using System;
using System.Collections.Generic;
using System.Text;

namespace TextRpg
{ 
    public enum CreatureType
    {
    None = 0,
    Character = 1,
    Monster = 2
    }


    public class Creature
    {
        CreatureType type;
        protected int hp;
        protected int attack;

        public Creature(CreatureType type)
        {
            this.type = type;
        }
        public int Hp { get { return hp; } set { this.hp = value; } }
        public void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }



    }
}
