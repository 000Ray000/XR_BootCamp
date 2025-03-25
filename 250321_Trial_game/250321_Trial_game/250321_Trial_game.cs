using System;

namespace _250321_Trial_game
{
        internal class Program
        {

            static void Main(string[] args)
            {

                // 1. 게임 오버 판단 / 2. 플레이어 / 3. 맵 
                bool gameOver;
                char[,] map;
                Position playerPos;

                Start(map, ref playerPos);

                while (gameOver == false)
                {

                    Render(ref playerPos, );
                    Input();
                    Update();

                }

                IsClear();

                End();


            }

            // 변수 영역

            struct Position
            {
                int x;
                int y;
            }

            // 함수 영역
            static void Start(Position playerPos, char[,] map, )
            {
            // 초기 플레이어 포지션, 맵, 환영 인사
            playerPos.x = 2;
            playerPos.y = 7;


            map = new char[8, 8]
            {
                {'#','#','#','#','#','#','#','#'},
                {'#',' ',' ','#',' ',' ',' ',' '},
                {'#','#',' ','#',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ','#',' ','#'},
                {'#',' ',' ','#',' ','#',' ','#'},
                {'#',' ','#','#',' ','#',' ','#'},
                {'#',' ',' ','#',' ','#',' ','#'},
                {'#','#','#','#','#','#','#','#'}
            };
    
            WelcomeMessage();

            }

            static void WelcomeMessage()
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Welcome to the mini-miny-maze!");
                Console.WriteLine("===============================");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Please Enter Your Name: ");
                string username = Console.ReadLine();
                Console.WriteLine($"Hello, {0}! Enjoy the Game! :D", username);
            }


            static void Render()
            {
                // 플레이어 출력하기
                // 특정 포지션에 무언가를 출력하고 싶다면? -> 콘솔의 커서를 만지기!
            }

            static void Input()
            {

            }

            static void Update()
            {

            }

            static void IsClear()
            {
                // 맵을 돌아보면서 2,8에 플레이어가 있으면 클리어

            }

            static void End()
            {

            }

        }
    }


