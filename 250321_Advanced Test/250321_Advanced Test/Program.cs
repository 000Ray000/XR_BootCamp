namespace _250321_Advanced_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 문제 1 출력

            Console.WriteLine("문제 1 출력");
            
            string[] words = { "abcdef", "Winner winner chicken dinner", "Not your lucky day" };
            char[] keys = { 'd', 'c', 'p' };

            Console.WriteLine(FindKeyIndex(words[0], keys[0]));
            Console.WriteLine(FindKeyIndex(words[1], keys[1]));
            Console.WriteLine(FindKeyIndex(words[2], keys[2]));

            Console.WriteLine("================================");
            Console.WriteLine();
            #endregion

            #region 문제 2 출력 

            Console.WriteLine("문제 2 출력");

            int[] testnums_prime = { 7, 4, 1 };

            Console.WriteLine(IsPrime(testnums_prime[0]));
            Console.WriteLine(IsPrime(testnums_prime[1]));
            Console.WriteLine(IsPrime(testnums_prime[2]));

            Console.WriteLine("================================");
            Console.WriteLine();
            #endregion

            #region 문제 3 출력


            Console.WriteLine("문제 3 출력");

            int[] testnums_digits = { 18234, 3849, 12345 };

            Console.WriteLine(SumOfDigits(testnums_digits[0]));
            Console.WriteLine(SumOfDigits(testnums_digits[1]));
            Console.WriteLine(SumOfDigits(testnums_digits[2]));

            Console.WriteLine("================================");
            Console.WriteLine();
            #endregion

            #region 문제 4 출력


            Console.WriteLine("문제 4 출력");

            int[] array1 = { 1, 5, 5, 10 };
            int[] array2 = { 3, 5, 5, 10 };

            int[] array3 = { 3, 5, 7, 9 };
            int[] array4 = { 7, 6, 5, 4 };

            int[] array5 = { 8, 7, 6, 5 };
            int[] array6 = { 1, 2, 3, 4 };

            Console.WriteLine(FindCommonItems(array1, array2));
            Console.WriteLine(FindCommonItems(array3, array4));
            Console.WriteLine(FindCommonItems(array5, array6));

            Console.WriteLine("================================");
            Console.WriteLine();
            #endregion

        }

        #region 문제 1. 
        // 주어진 문자열 중 찾는 문자가 있는 인덱스를 구하기.
        // 단, 찾는 문자가 없으면 -1을 반환한다.

        public static int FindKeyIndex(string text, char key)
        {
            // 반복문을 돌면서, 문자열을 살펴보고 센다.
            // 1. 문자열string을 char 열의 배열로 바꿔준다.
            // 2. char 배열을 반복문으로 돌면서 if문을 활용, 찾는 문자가 있으면 해당 인덱스를 확인, 뱉고,
            // 3. else if를 써서 count가 0이라면 -1을 반환한다.

            char[] strTochar = text.ToCharArray();

            for (int i = 0; i < strTochar.Length; i++)
            {
                if (key == strTochar[i])
                {
                    return i;
                }

            }

            return -1;

            // 입력: "abcdef", 'd'
            // 출력: 3

            // 입력: "Winner winner chicken dinner", 'c'
            // 출력: 14

            // 입력: "Not your lucky day", 'p'
            // 출력: -1


            // 번외, foreach를 쓸 경우.
            // foreach를 사용할 경우 인덱스를 주어야 하니까, 함수 밖에서 인덱스를 정의하고,
            // 그 후 요소를 하나씩 돌 때마다 인덱스를 추가해주는 형태로도 가능하다.

            /*
            char[] strTochar = text.ToCharArray();
            int index = 0;

            foreach (char c in strTochar)
            {
            if (c == key)
            {
            return index;
            }
            index++;
            }

            return -1;
        
              */
        }
        #endregion

        #region 문제 2. 
        // 주어진 숫자가 소수인지 판별하는 함수를 작성하시오.

        public static bool IsPrime(int number)
        {
            // 소수인지 판별해서 bool로 T/F을 반환하면 될 것이고.
            // 소수인지 확인 여부는 어떻게 아는가? 
            // 1과 나로만 나눠지면 소수. 
            // 어떤 수를 그 수보다 작은 수들로 전부 나눠봤을 때, 나머지가 전부 0이 아니면 된다.
            // 1로 나눴을 때 나머지가 0이고, 그 외에는 전부 나머지가 0이 아니다. 그게 소수.
            // 그렇다면, for 문을 돌면서 반복하면 된다.

            // 1과 2는 특수한 수이므로 따로 처리.
            if (number == 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            // 2보다 큰 수 중 판별
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;

        }

        // 입력 7 / 출력 true
        // 입력 4 / 출력 false
        // 입력 1 / 출력 false


        #endregion

        #region 문제 3.
        // 주어진 숫자의 각 자리수의 합을 구하는 함수를 만들기

        // 자리수에서, 그 숫자들의 수 만을 분리해내야 한다.
        // 123 이라면 1의 경우는 123 나누기 100을 하면, 정수이니까 1만 남는다.
        // 인덱스를 뒤에서부터 살펴보면서 그 인덱스 값만큼 10의 제곱을 나눠주면 된다. 
        // 그렇게 나오게 된 몫을 순서대로 합계 변수에 더해주면 됨.

        // 아니면, 숫자열을 문자열로 변환하고, 그 문자열을 문자형의 배열로 만들고, 
        // 문자형의 배열들을 문자열의 길이를 받아와서 반복하면서 하나씩 더해주고 반환하면 되지 않을까?


        public static int SumOfDigits(int number_3)
        {

            // 문자형 -> 문자열 배열 -> 정수형 배열
            string strNumber_3 = number_3.ToString();
            char[] charArrNumber_3 = strNumber_3.ToCharArray();
            int[] intArrNumber_3 = new int[charArrNumber_3.Length];

            for (int i = 0; i < charArrNumber_3.Length; i++)
            {
                intArrNumber_3[i] = charArrNumber_3[i] - '0';
            }

            //정수형 배열 수를 전부 더해주기.
            int sum = 0;

            for (int i = 0; i < intArrNumber_3.Length; i++)
            {
                sum += intArrNumber_3[i];
            }

            return sum;

        }

        // 입력 18234 / 출력 18 
        // 입력 3849 / 출력 24
        // 입력 12345 / 출력 15

        #endregion


        #region 문제 4.
        // 주어진 두 배열에서 공통항목을 찾는 함수를 작성. 단, 중복 X

        // 배열에서 공통 항목을 찾으려면, for문을 돌면서 반복은 해야할 것.
        // 두 항목이 같은 지 비교하려면, 배열 1과 배열 2의 요소를 빼서 0이 되면 같은 것이다.
        // 그 항목들을 차례 차례로 배열에 저장해주면 된다. 
        // 다만, 배열은 길이가 정해져야 한다. 배열의 길이는 각 두 개의 배열 중 짧은 배열의 길이가 최대치일것. 
        // 하지만, 그 배열 속에서 값이 할당되지 않은 부분은 어떻게 할까? -> int 배열은 전부 0으로 초기화되어있다.
        // 중복은 어떻게 해결할까? 
        // 중복도 그 공통 항목들끼리 비교해보고, 빼서 0이 되는 수가 있으면 한 쪽을 지워주면 된다. 
        // 


        public static int[] FindCommonItems(int[] array1, int[] array2)
        {

        }

        // 입력 
        // int[] array1 = { 1, 5, 5, 10 };
        // int[] array2 = { 3, 5, 5, 10 };
        // 출력 / { 5, 10 }

        // 입력
        // int[] array3 = { 3, 5, 7, 9 };
        // int[] array4 = { 7, 6, 5, 4 };
        // 출력 / { 5, 7 }

        // 입력
        // int[] array5 = { 8, 7, 6, 5 };
        // int[] array6 = { 1, 2, 3, 4 };
        // 출력 / null


        #endregion

    }
}   
