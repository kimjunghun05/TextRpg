using System;
using System.Collections.Generic;
using System.Text;

/*
 * 로비 --> 캐릭터 선택창
 * 캐릭터 선택 후 맵 선택 및 진입 가능
 * 맵을 들어가면 적을 만남 만나면 싸우거나 도망
 * 적을 잡으면 휴식하러 가기 가능
 * 휴식하러 로비로 가면 체력 완전 회복
 */

/*현재 게임 상태에 따른 게임 진행
 * gamemode 가 lobby이면 
 * gamemode 가 map이면
 * 처음 시작은 lobby
 */

namespace TextRpg
{
    public enum GameMode
    {
        None = 0,
        Lobby = 1,
        Map = 2
    }
    class Game
    {
        Lobby lobby = new Lobby();
        GameMode mode = GameMode.Lobby;
        Map map = new Map(MapType.None);
        Character character = new Character(CharacterType.None);
        Monster monster = new Monster(MonsterType.None);
        public void ProcessGame()
        {
            switch(mode)
            {
                case GameMode.Lobby:
                    lobby.LobbyProcess(character);
                    mode = GameMode.Map;
                    Console.WriteLine("맵선택");
                    Console.WriteLine("1 고블린");
                    Console.WriteLine("2 오크");
                    Console.WriteLine("3 오우거");
                    break;

                case GameMode.Map:
                    map = map.SelectMap();
                    break;

                default:
                    break;
            }

        }

    }


}
