using System;
using System.Collections.Generic;
using System.Text;

/*
 * 고블린
 * 오크
 */
namespace TextRpg
{
    public enum MonsterType
    {
        None = 0,
        Goblin = 1,
        Orc =2,
        Ogre = 3
    }

    class Monster : Creature 
    {
        MonsterType type;
 

        public Monster(MonsterType type) : base(CreatureType.Monster)
        {
            this.type = type;
        }
    }

    class Goblin : Monster
    {
        public Goblin() : base(MonsterType.Goblin)
        {
            SetInfo(20, 5);
        }

    }

    class Orc : Monster
    {
        public Orc() : base(MonsterType.Orc)
        {
            SetInfo(30, 6);
        }
    }
    
    class Ogre : Monster
    {
        public Ogre() : base(MonsterType.Ogre)
        {
            SetInfo(40, 8);
        }
    }


}
