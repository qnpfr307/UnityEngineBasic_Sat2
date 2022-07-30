using System;

// Variables (변수): 아직 값을 모르는 상징적인 이름(식별 문자)
int a = 3; // 전역 변수(글로벌 변수)

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Swordman
    {
        // 자료형(Data Type): 데이터의 종류를 식별하기 위한 분류(ex: int, float, double, char ...)
        // bit: 1자리 이진수(0, 1). 정보 처리의 최소 단위
        // byte: 8 bit = 1 byte (CPU의 데이터 처리 최소 단위). 4 byte == 32 bit

        // 초기화: 변수 선언과 동시에 값을 넣는 것

        int lv; // 4 byte 크기의 부호가 있는 정수 자료형(-2^31 ~ 2^31 -1 범위의 숫자 표현 가능)
                // uint: unsigned integer - 부호가 없는 정수 자료형
        float exp; // 4 byte 크기의 실수 자료형
                   // double: 8 byte 크기의 실수 자료형
        bool isAvailable; // bool: 논리형, true(0이 아닌 수)와 false(0)로 구분함. 1 byte
        char gender; // char: 문자형. 2 byte. ASCII 코드 형식으로 인해 정수형으로 저장됨.
        char[] name1; // 배열: 연속된 자료형 타입
        //String name2; = new String('c', 3); // String 객체 참조형
        string name3; // string: 문자열형

        // 멤버 변수
        // 클래스 내에 선언된 변수
    }
}
