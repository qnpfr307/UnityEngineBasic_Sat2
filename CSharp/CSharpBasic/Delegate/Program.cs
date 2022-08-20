using System;
using Delegate;

// Delegate: 대리자
// 함수 포인터 타입 (함수를 대입해뒀다가 호출할 수 있도록 해줌.)
// delegate 키워드로 대리자를 정의할 수 있음.
// 정의한 대리자 타입의 대리자 변수를 선언해서 사용함.


namespace Delegate
{
    internal class Program
    {
        public delegate int DelegateHandler(int a, int b);

        public static event DelegateHandler opDelegate;
        // event 한정자
        // delegate 를 위한 한정자.
        // 외부 클래스엣 ㅓ함수를 대리자에 등록하거나 제거할 수는 있으나, 직접 대리자를 호출할 수는 없도록 하는 한정자.

        public static Action<int, int> opAction;
        public static Func<int, int, int> opFunc;
        static void Main(string[] args)
        {
            // 함수 체이닝(Chaining)
            // opDelegate += OPs.Sum;
            // opDelegate += OPs.Sub;
            // opDelegate += OPs.Mul;
            // opDelegate += OPs.Div;
            // opDelegate += OPs.Mod;
            // 
            // opDelegate -= OPs.Mod;

            OPs.Init();

            while (true)
            {
                Console.WriteLine("연산을 수행하려면 DoOP를 입력하세요.");
                string input = Console.ReadLine();

                if (input == "DoOP")
                {
                    int a = 0, b = 0;
                    Console.WriteLine("첫 번째 피연산자를 입력하세요.");
                    try
                    {
                        a = Int32.Parse(Console.ReadLine());
                    }
                    catch(FormatException e)
                    {
                        Console.WriteLine("정수를 입력하세요.");
                        Console.WriteLine(e.Message);
                    }                   
                    finally
                    {
                        // 예외 catch가 되든 안 되든 마지막에 수행하고 싶은 내용 기재
                    }
                    Console.WriteLine("두 번째 피연산자를 입력하세요.");
                    try
                    {
                        b = Int32.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("정수를 입력하세요.");
                    }

                    // OPs.Sum(a, b);
                    // OPs.Sub(a, b);
                    // OPs.Mul(a, b);
                    // OPs.Div(a, b);
                    // OPs.Mod(a, b);

                    opDelegate(a, b);

                    opAction += delegate(int a, int b)
                    {
                        Console.WriteLine(a + b);
                    };
                    opAction(1, 2);

                    // 람다식 등록
                    opAction += (a, b) => { Console.WriteLine(a + b); };
;                }
            }
        }

        (a, b) =>
            {
            Console.WriteLine(a + B);
            }

        public static void RegisterCallBack(DelegateHandler delegateHandler)
        {
            opDelegate += delegateHandler;
        }
    }
}
