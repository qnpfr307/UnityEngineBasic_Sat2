using System;

namespace ClassUsageBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new SwordMan().lv);
            SwordMan swordMan = new SwordMan(); // new 키워드: (참조 형식에 대해서)힙 영역에 동적 할당하는 키워드
            swordMan.SayName(); // 연산자: 멤버 접근 연산자

            int a = 3;
            Test(a);
            Console.WriteLine(a);

            Test(swordMan);
            Console.WriteLine(swordMan.lv);
        }

        static void Test(SwordMan swordMan)
        {
            swordMan.lv = 5;
        }
        static void Test(int index)
        {
            index = 5;
        }
    }

    // 값 타임 vs 참조 타입
    // 값 타입: 값을 복사해서 직접 할당함. (int, float, double, struct ...)
    // 참조 타입: 해당 힙 영역의 참조(주소)를 할당함. (class, string ...)

    // 클래스는 참조 타입
    // 클래스의 멤버들은 기본적으로 접근이 제한되어있음 (private)

    // 접근 제한자
    // private: 외부 접근 불가
    // public: 외부 접근 가능
    // protected: 자식 객체만 접근 가능
    // internal: 동일 어셈블링에서 접근 가능

    class SwordMan
    {
        public int lv = 1;
        private float exp;
        private bool isAvailable;
        private char gender;
        private string name;

        // 생성자와 소멸자도 멤버 함수

        // 생성자
        // 객체를 힙 영역에 할당하는 함수
        public SwordMan()
        {

        }

        // 소멸자
        // 객체를 메모리에서 해제하는 함수
        ~SwordMan()
        {

        }


        public void SayName()
        {
            Console.WriteLine(name);
        }
    }
}
