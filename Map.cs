using System;
using System.Collections.Generic;
using System.Text;

/*
 * 고블린맵
 * 오크맵
 * 오우거맵
 * 몬스터 생성기능
 * */
namespace TextRpg
{


    public enum MapType
    {
        None = 0,
        GoblinMap = 1,
        OrcMap = 2,
        OgreMap = 3
    }

    class Map
    {
        protected Monster monster = new Monster(MonsterType.None);
        protected MapType type;

        public Map(MapType type)
        {
            this.type = MapType.None;
        }

        public Monster SelectMonster(MapType type)
        {


            switch (type)
            {
                case MapType.None:
                    Console.WriteLine("null");
                     return null;

                case MapType.GoblinMap:
                    Goblin goblin = new Goblin();
                    Console.WriteLine("goblin");
                    return goblin;

                case MapType.OrcMap:
                    Orc orc = new Orc();
                    Console.WriteLine("orc");
                    return orc;

                case MapType.OgreMap:
                    Ogre ogre = new Ogre();
                    Console.WriteLine("Ogre");
                    return ogre;

                default:
                    return null;
            }
        }

        public Map SelectMap()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    GoblinMap gm = new GoblinMap();
                    return gm;

                case "2":
                    OrcMap orcm = new OrcMap();
                    return orcm;

                case "3":
                    OgreMap ogrem = new OgreMap();
                    return ogrem;

                default:
                    Console.WriteLine("return null");
                    return null;

            }

        }


    }

    class GoblinMap : Map
    {
        public GoblinMap() : base(MapType.GoblinMap)
        {
            
            this.type = MapType.GoblinMap;
            this.SelectMonster(type);
            Console.WriteLine("GoblinMap");
        }

    }

    class OrcMap : Map
    {
        public OrcMap() : base(MapType.OrcMap)
        {
            this.type = MapType.OrcMap;
            this.SelectMonster(type);
            Console.WriteLine("OrcMap");
        }

    }

    class OgreMap : Map
    {
        public OgreMap() : base(MapType.OgreMap)
        {
            this.type = MapType.OgreMap;
            this.SelectMonster(type);
            Console.WriteLine("OgreMap");
        }

    }
}
