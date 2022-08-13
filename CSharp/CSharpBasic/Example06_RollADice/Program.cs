using System;

namespace Example06_RollADice
{
    internal class Program
    {
        static private int totalTile = 20; // 맵 칸 (20)
        static private int totalDice = 20; // 초기 주사위 갯수 (20)
        static private int totalPoint = 0; // 현재 점수(모은 샛별)
        static private int currPlayer = 0; // 현재 플레이어 위치
        static private int prevPlayer = 0; // 이전 플레이어 위치
        static private Random random; // 주사위 굴릴 때 1 ~ 6 중의 난수 생성

        static void Main(string[] args)
        {
            TileMap map = new TileMap();
            map.MapSetUp(totalTile);
            int currDice = totalDice; // 남은 주사위 저장 변수
            
            while (currDice > 0) // 남은 주사위가 0이 될 때까지 굴림
            {
                Console.WriteLine("Enter 키를 눌러 주사위를 굴리세요.");
                int diceValue = RollaDice();
                currDice--;
                currPlayer += diceValue; // 플레이어 전진

                int passedStarTileNum = currPlayer / 5 - prevPlayer / 5;

                for (int i = 0; i < passedStarTileNum; i++)
                {
                    int starTileIndex = (currPlayer / 5 - i) * 5;

                    if (currPlayer > totalTile)
                        currPlayer -= totalTile;

                    if (map.TryGetTileInfo(starTileIndex, out Tileinfo tileinfo_star))
                    {
                        totalPoint += (tileinfo_star as Tileinfo_Star).starValue;
                    }
                    else
                    {
                        throw new Exception("뭔가 잘못되었습니다!!!(샛별칸 정보 불러오기 실패)");
                    }
                }



                if (map.TryGetTileInfo(currPlayer, out Tileinfo tileinfo))
                {
                    tileinfo.OnTile();
                }
                else
                {
                    throw new Exception("뭔가 잘못되었습니다!!!(플레이어가 맵을 이탈)");
                }

                prevPlayer = currPlayer;
                Console.WriteLine($"현재 샛별 점수: {totalPoint}");
                Console.WriteLine($"남은 주사위 갯수: {currDice}");
            }

            Console.WriteLine($"게임 끝! 당신의 점수: {totalPoint}점");
        }

        static private int RollaDice()
        {
            // 주사위를 굴리라는 메세지 출력
            // 엔터키를 입력 받고 주사위를 굴림
            // 나온 수에 따라 주사위 눈을 출력함
            // 나온 수 만큼 플레이어의 위치를 증가시킴. (플레이어 위치 + 주사위 눈)
            // 플레이어의 위치가 샛별칸이라면 얻을 수 있는 샛별을 1 증가시킴. (위치 확인 -> 이전 플레이어 위치 + 주사위 눈 (-20(20초과시)) = 5의 배수인가?)
            // 플레이어가 샛별칸을 지났다면 샛별을 추가함 (3)
            // 플레이어의 위치가 20을 초과하면 전체 맵 개수인 20을 빼서 1~20의 수로 만듦.
            // 모든 주사위 (20개)를 소모할 때까지 위 과정을 반복.

            string UserInput = "Default"; // 플레이어 키 입력 받을 변수
            while (Console.ReadLine() != "") // 엔터키 누를때까지 대기
            {
                Console.WriteLine("Enter 키를 눌러 주사위를 굴리세요.");
                UserInput = Console.ReadLine();
                if (UserInput != "") // 엔터키 말고 다른 키 누르면
                    Console.WriteLine("그건 Enter 키가 아니예요...");
                else
                    break;
            }

            random = new Random();
            int diceValue = random.Next(1, 7);
            Console.WriteLine($"주사위를 굴렸다! 나온 눈은... {diceValue} !!");
            ShowDice(diceValue); // 나온 눈에 따라 플레이어에게 주사위를 보여주는 함수로 이동

            return diceValue; // 주사위 눈을 반환
            
        }
        static private void ShowDice(int diceValue) // 플레이어에게 주사위를 보여줌
        {
            switch(diceValue)
            {
                case 1:
                    Console.WriteLine("┌───────┐");
                    Console.WriteLine("│ 　　　│");
                    Console.WriteLine("│ 　☆　│");
                    Console.WriteLine("│ 　　　│");
                    Console.WriteLine("└───────┘");
                    break;
                case 2:
                    Console.WriteLine("┌───────┐");
                    Console.WriteLine("│ 　　　│");
                    Console.WriteLine("│ ☆　☆│");
                    Console.WriteLine("│ 　　　│");
                    Console.WriteLine("└───────┘");
                    break;
                case 3:
                    Console.WriteLine("┌───────┐");
                    Console.WriteLine("│ ☆　　│");
                    Console.WriteLine("│ 　☆　│");
                    Console.WriteLine("│ 　　☆│");
                    Console.WriteLine("└───────┘");
                    break;
                case 4:
                    Console.WriteLine("┌───────┐");
                    Console.WriteLine("│ ☆　☆│");
                    Console.WriteLine("│ 　　　│");
                    Console.WriteLine("│ ☆　☆│");
                    Console.WriteLine("└───────┘");
                    break;
                case 5:
                    Console.WriteLine("┌───────┐");
                    Console.WriteLine("│ ☆　☆│");
                    Console.WriteLine("│ 　☆　│");
                    Console.WriteLine("│ ☆　☆│");
                    Console.WriteLine("└───────┘");
                    break;
                case 6:
                    Console.WriteLine("┌───────┐");
                    Console.WriteLine("│ ☆　☆│");
                    Console.WriteLine("│ ☆　☆│");
                    Console.WriteLine("│ ☆　☆│");
                    Console.WriteLine("└───────┘");
                    break;
                default:
                    throw new Exception("뭔가 잘못되었습니다!!!(1 ~ 6 사이의 수가 나오지 않음)");
            }            
        }
    }
}
