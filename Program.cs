using System;

/* 게임 구현 
 * 1. 로비
 * 2. 캐릭터
 * 3. 맵 선택 가능   
 * 4. 전투 or 도망
 * 5. 레벨업
 * 6. 휴식
 */

namespace TextRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            while (true)
            {
                game.ProcessGame();
            }

        }
    }
}
