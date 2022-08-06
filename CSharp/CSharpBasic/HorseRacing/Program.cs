using System;
using System.Threading;


/* 프로그램 시작시 말 다섯 마리를 만들고
 * 각 다섯 마리는 초당 10 ~ 20 (정수형) 범위 거리를 랜덤하게 움직임
 * 각각의 말이 거리 200에 도달하면 말의 이름과 등수를 출력해줌
 * 
 * 말은 이름, 달린 거리를 멤버 변수로, 달리기를 멤버 함수로 가짐.
 * 달리기 멤버 함수는 입력 받은 거리를 달린 거리에 더해주어서 달린 거리를 누적시키는 역할을 함.
 * 
 * 매초 달릴때 마다 각 말들이 얼마나 거리를 이동했는지 콘솔창에 출력해줌.
 * 경주가 끝나면 1, 2, 3, 4, 5 등 말의 이름을 등수 순서대로 콘솔창에 출력해줌.
 */

namespace Example02_HorseRacing
{
    internal class Program
    {
        static Random random;
        static int minSpeed = 10;
        static int maxSpeed = 20;
        static bool isFinished = false;
        static int finishDistance = 200;
        static void Main(string[] args)
        {
            // 말 생성하고 이름 만들기
            Horse[] horses = new Horse[5];
            string[] FinishedHorseName = new string[5];
            int currentGrade = 1;
            int length = horses.Length;
            for (int i = 0; i < length; i++)
            {
                horses[i] = new Horse();
                horses[i].name = $"{i + 1}번마";
            }

            // 말 이름 바꾸기
            if(horses[0].name == "1번마")
            {
                horses[0].name = "페가수스";
            }
            if (horses[1].name == "2번마")
            {
                horses[1].name = "황소";
            }
            if (horses[2].name == "3번마")
            {
                horses[2].name = "적토마";
            }
            if (horses[3].name == "4번마")
            {
                horses[3].name = "당나귀";
            }
            if (horses[4].name == "5번마")
            {
                horses[4].name = "노새";
            }

            //
            Console.WriteLine("경주 시작!");
            int sec = 0;
            // 다 들어갈 때까지 경주를 함
            while (!isFinished)
            {
                if(sec >= 10)
                {
                    Console.WriteLine($"############## {sec} 초 경과 #############");
                }
                else
                {
                    Console.WriteLine($"############## {sec} 초 경과 ##############");
                }
                for (int i = 0; i < length; i++)
                {
                    if (horses[i].goal == false)
                    {
                        random = new Random();
                        int tmpMoveDistance = random.Next(minSpeed, maxSpeed + 1);
                        horses[i].Run(tmpMoveDistance);
                        Console.WriteLine($"{horses[i].name}가 달린거리 : {horses[i].distance}");
                        if (horses[i].distance >= finishDistance)
                        {
                            horses[i].goal = true;
                            FinishedHorseName[currentGrade - 1] = horses[i].name;
                            currentGrade++;
                        }
                    }
                }
                // 5등 까지 다 들어왔으면 경주를 끝냄
                    Console.WriteLine($"#######################################");
                if (currentGrade > 5)
                {
                    isFinished = true;
                    Console.WriteLine("경주 끝!");
                    break;
                }

                Thread.Sleep(1000);
                sec++;
            }
            // 결과 발표
            Console.WriteLine("############## 결과 발표 ##############");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i + 1}등: {FinishedHorseName[i]}");
            }


            Console.WriteLine("");
            Console.WriteLine("축하합니다!");
            Console.WriteLine("############## 경기 종료 ##############");
            Console.WriteLine("");
        }
    }

    public class Horse
    {
        public string name;
        public int distance;
        public bool goal;

        public void Run(int moveDistance)
        {
            distance += moveDistance;
        }
    }
}
