using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace _250325_Trainer_Monster_Implementation
{

    /* 과제 1. 트레이너와 몬스터 제작
   트레이너와 몬스터 클래스를 구현해야 하고, 다음의 속성과 기능을 가져야 함.

   Class Trainer
   이름 : 플레이어 이름, 프로그램 시작 시 입력하도록 구현
   몬스터를 보관할 수 있는 크기 6의 배열
   Add() : 매개변수로 몬스터를 하나 입력받아 배열의 빈 자리에 추가. 빈 자리가 없다면 추가되지 않음
   Remove() : 매개변수로 몬스터를 하나 입력받아 동일한 이름을 가진 몬스터를 배열에서 삭제. 
   이름에 해당하는 몬스터가 없거나 배열에 몬스터가 한마리도 없는 경우 아무 기능도 수행하지 않음.
   PrintAll() : 자신이 가지고 있는 모든 포켓몬에 대한 정보를 출력


   Class Monster
   이름, 레벨 : 객체의 인스턴스 생성 시 new할당에서 이름과 레벨을 입력받을 수 있도록 구현
   Print() : 자신(몬스터)에 대한 정보를 출력

   */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("플레이어의 이름을 입력해주세요.");
            string playerName = Console.ReadLine();

            Trainer trainer = new Trainer(playerName);

            Console.Write("몬스터의 이름은? ");
            string monsterName = Console.ReadLine();

            Console.Write("몬스터의 레벨은? ");
            int monsterLevel = int.Parse(Console.ReadLine());

            Monster monster = new Monster(monsterName, monsterLevel);

            monster.Print(monsterName, monsterLevel);

            trainer.Add(monsterName);
            trainer.PrintAll();
            trainer.Remove(monsterName);
            trainer.PrintAll();


        }
    }

    class Trainer
    {
        public string playername;
        public string[] monsterBall = new string[5];

        // 이 아이디어 기억할 것. 배열에 하나 추가할 때는 현재 배열 길이 -1한 인덱스에 넣어주면 바로 끝에 들어간다.
        public void Add(string monsterName)
        {
            if (monsterBall.Length < 6)
            {
                monsterBall[monsterBall.Length - 1] = monsterName;
                Console.WriteLine(monsterName + "를 몬스터볼에 추가합니다.");
            }
            else if (monsterBall.Length == 6)
            {
                Console.WriteLine("몬스터볼이 꽉 찼습니다.");
            }
        }

        public void Remove(string monsterName)
        {
            if (monsterBall == null)
            {

            }
            else
            {
                for (int i = 0; i < monsterBall.Length; i++)
                {
                    if (monsterBall[i] == monsterName)
                    {
                        Console.WriteLine(monsterName + "를 삭제합니다.");
                        monsterBall[i] = null;
                    }
                }

            }

        }

        public void PrintAll()
        {
            foreach (string monsterName in monsterBall)
            {
                Console.WriteLine($"현재 몬스터볼에는 " + monsterName + "가 있습니다.");
            }
        }

        public Trainer(string playername)
        {
            this.playername = playername;
            monsterBall = new string[5];
        }

    }

        class Monster
        {
            string monstername;
            int monsterlevel;

            public void Print(string monstername, int monsterlevel)
            {
                Console.WriteLine(monstername + ", Level. "  +  monsterlevel);
            }

            public Monster(string monstername, int monsterlevel)
            {
                this.monstername = monstername;
                this.monsterlevel = monsterlevel;
            }
        }



    

}
