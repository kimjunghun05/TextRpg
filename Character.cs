using System;
using System.Collections.Generic;
using System.Text;


/* 게임 구현 
전사
도적
궁수
법사
 */
namespace TextRpg
{
    class Character
    {
        protected int hp;
        protected int attack;

        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        public void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }


    }

    class Knight : Character
    {
        public Knight()
        {
            SetInfo(100, 10);
        }

    }

    class Rogue : Character
    {


    }

    class Archer : Character
    {


    }

    class Mage : Character
    {


    }
}
