using System;
using System.Collections.Generic;
using System.Text;


/* 게임 구현 
전사
도적
궁수
법사
 */

public enum CharacterType
{
    None = 0,
    Knight = 1,
    Rogue = 2,
    Archer = 3,
    Mage = 4
}
namespace TextRpg
{
    public class Character
    {
        protected int hp;
        protected int attack;
        protected CharacterType type;

        public Character(CharacterType type)
        {
            this.type = type;
        }

        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        public CharacterType getType()
         {
            return this.type;
         }

        public void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

 
    }


    public class Knight : Character
    {
        public Knight() : base(CharacterType.Knight)
        {
            SetInfo(100, 10);
        }

    }

    public class Rogue : Character
    {
        public Rogue() : base(CharacterType.Rogue)
        {
            SetInfo(60, 15);
        }

    }

    public class Archer : Character
    {
        public Archer() : base(CharacterType.Archer)
        {
            SetInfo(80, 13);
        }

    }

    public class Mage : Character
    {
        public Mage() : base(CharacterType.Mage)
        {
            SetInfo(50, 17);
        }

    }
}
