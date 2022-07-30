using System;

/* 
 * 1. Orc 클래스 작성
 * 1-1. 멤버 변수: 이름, 키, 몸무게, 나이, 성별문자, 컨트롤 가능한 지의 여부\
 * 1-2. 멤버 함수: 휘두르기(Smash), 점프하기(Jump). 콘솔 창에 휘둘렀다/점프했다 등의 출력만 함)
 * 2. Orc 객체 생성하는 코드 작성
 * 2-1. main 함수 내에 오크 객체 두개 생성
 * 3. Orc 객체 멤버 변수 값 할당 하는 코드 작성
 * 3-1. 첫 번째 오크
 *      이름: 상급오크
 *      키: 240f
 *      몸무게: 200f
 *      나이: 3
 *      성별문자: 남
 *      컨트롤 가능 여부: Y
 * 3-2. 두 번째 오크
 *      이름: 하급오크
 *      키: 300f
 *      몸무게: 150f
 *      나이: 21
 *      성별문자: 여
 *      컨트롤 가능 여부: N
 * 4. Orc 객체 멤버 함수 호출하는 코드 작성
 * 4-1. 상급오크는 휘두르기, 하급오크는 점프하기를 main 함수에서 실행
 * 4-2. 출력예시
 *      상급오크 (이)가 휘둘렀다...!
 *      하급오크 (이)가 점프했다...!
*/
namespace Example01_ClassObjectinstance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc("오크", "상급오크", 240.0f, 200.0f, 3, '남', true);
            Orc orc2 = new Orc("오크", "하급오크", 300.0f, 150.0f, 21, '여', false);

            orc1.Smash();
            orc2.Jump();
            Console.WriteLine(orc1._name);
            Console.WriteLine(Orc._tribe);

            Orc.PrintTribe();
        }
    }

        public class Orc
        {
            public static string _tribe;

            public string _name;
            private float _height;
            private float _weight;
            private int _age;
            private bool _isControllable;
            private char _gender;

            //함수 오버로딩
            //동일한 이름이어도 다른 파라미터를 가지는 함수들에 대해서 정의할 수 있는 기능
            //객체지향컨셉의 다형성 요소 중 하나
            public Orc(string tribe, string name, float height, float weight, int age, char gender, bool isControllable)
            {
                _tribe = tribe;
                _name = name;
                _height = height;
                _weight = weight;
                _age = age;
                _gender = gender;
                _isControllable = isControllable;
            }
            public void Smash()
            {
                Console.WriteLine($"{_name}이가 휘둘렀다...!");
            }
            public void Jump()
            {
                Console.WriteLine($"{_name}이가 점프했다...!");
            }

        //static 함수는 인스턴스를 통해서 호출할 수 있는 함수가 아님. 클래스를 통해서 호출함.
            public static void PrintTribe()
        {
            Console.WriteLine(_tribe);
        }
        }
    }
