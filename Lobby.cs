using System;
using System.Collections.Generic;
using System.Text;


//캐릭터가 있을때 ->맵 들어가기
//캐릭터가 없을떄 ->캐릭터 고르기
namespace TextRpg
{
    class Lobby
    {
        GameMode mode;
        
        public Lobby()
        {
            this.mode = GameMode.Lobby;
        }
        public Character SelectCharacter()
        {
            Character character;
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": 
                    Knight knight = new Knight();
                    return knight;
                  
                case "2":
                    Rogue rogue = new Rogue();
                    return rogue;
                   
                case "3":
                    Archer archer = new Archer();
                    return archer;
                   
                case "4":
                    Mage mage = new Mage();
                    return mage;
                 
      
                default:
                    return null;

            }
        }

        public void LobbyProcess(Character character)
        {
            bool isNone;
            if ((int)character.getType() == 0)
                isNone = true;
            else
                isNone = false;
            
            if (isNone)
            {
                Console.WriteLine("여기는 로비입니다");
                Console.WriteLine("캐릭터를 선택하세요");
                Console.WriteLine("1.전사");
                Console.WriteLine("2.도적");
                Console.WriteLine("3.궁수");
                Console.WriteLine("4.법사");
                character = SelectCharacter();
            }

            else
            {
                //체력을 회복시켜준다 , 맵을 알려준다
                Console.WriteLine("체력이 회복되었습니다.");
                Console.WriteLine("맵을 선택하여주십시오");
                Console.WriteLine("1.고블린맵");
                Console.WriteLine("2.오크맵");
                Console.WriteLine("3.오우거맵");
            }
        }
        
    }
}
