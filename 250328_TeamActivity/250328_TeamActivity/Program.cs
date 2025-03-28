namespace _250328_TeamActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 숫자를 입력해주세요. ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("두 번째 숫자를 입력해주세요. ");
            int num2 = int.Parse(Console.ReadLine());



            Queue<int> queue = new Queue<int>();

            // 받아온 수 만큼 추가 
            for (int i = 1; i < num1 + 1; i++)
            {
                queue.Enqueue(i);
            }

 
        }
    }

    /*
    1. n까지 1부터 순서대로 큐에 넣는다. 
    2. 큐의 헤드에서 시작해서 살펴보며 n-1 번째 인덱스에 있는 것을 제거한다.
    3. 제거한 항목은 n의 사이즈를 갖는 배열에 순서대로 추가한다.
     */


}
