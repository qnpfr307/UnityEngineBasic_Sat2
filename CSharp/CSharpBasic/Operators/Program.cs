using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 6;
            int c = 0;

            // 산술 연산자
            // 더하기(+), 빼기(-), 곱하기(*), 나누기(/), 나머지(%)
            // ====================================================

            // 더하기
            c = a + b;
            Console.WriteLine(c);

            // 빼기
            c = a - b;
            Console.WriteLine(c);

            // 곱하기
            c = a * b;
            Console.WriteLine(c);

            // 나누기
            // 정수 나눗셈은 소숫점을 버린 정수를 반환
            c = a / b;
            Console.WriteLine(c);

            // 나머지
            // 자료형의 관계없이 정수 나눗셈의 결과를 반환함.(실수는 나머지가 없으므로)
            c = a % b;
            Console.WriteLine(c);

            // 증감 연산자
            // 증가 연산자, 감소 연산자
            // ====================================================

            // 증가 연산
            ++c; // 전위 연산: 해당 행의 연산을 한 뒤 명령을 실행함.
            c++; // 후위 연산: 해당 행의 명령을 실행한 뒤 연산을 실행함.

            c = 0;

            Console.WriteLine("증가연산 출력");
            Console.WriteLine(c);
            Console.WriteLine(++c);
            Console.WriteLine(c++);
            Console.WriteLine(c);

            // 감소 연산
            --c;
            c--;

            // 관계 연산자
            // 같음, 다름, 크기 등의 비교 연산자
            // 관계 연산자의 연산 결과가 참이면 true, 거짓하면 false 반환.
            // ====================================================

            Console.WriteLine("관계연산 출력");
            // 같음 비교
            Console.WriteLine(a == b);
            // 다름 비교
            Console.WriteLine(a != b);

            // 크기 비교

            // 초과
            Console.WriteLine(a > b);
            // 이상
            Console.WriteLine(a >= b);
            // 미만
            Console.WriteLine(a < b);
            // 이하
            Console.WriteLine(a <= b);

            // 대입 연산자
            // ====================================================
            c = 20;
            c += b; // c = c + b;
            c -= b; // c = c - b;
            c *= b; // c = c * b;
            c /= b; // c = c / b;
            c %= b; // c = c % b;

            // 논리 연산자
            // or, and, xor, not
            // ====================================================

            bool A = true;
            bool B = false;
            Console.WriteLine("논리연산 출력");

            // or
            // 둘 중 하나라도 참이면 true 반환
            Console.WriteLine(A | B);
            // and
            // 둘 다 참일 때만 true 반환
            Console.WriteLine(A & B);
            // xor
            // 둘 중 하나만 참이면 true 반환
            Console.WriteLine(A ^ B);
            // not
            // 피연산자가 true면 false, false면 true 반환.
            Console.WriteLine(!A);
            Console.WriteLine(!B);

            // 조건부 논리 연산자
            // 조건부 or, 조건부 and
            // ====================================================

            Console.WriteLine("조건부 논리연산 출력");
            // 조건부 or
            // 첫 번째 피연산자가 true면 비교하지 않고 true 반환
            Console.WriteLine(A || B);

            // 조건부 and
            // 첫 번째 피연산자가 false면 비교하지 않고 false 반환
            Console.WriteLine(A && B);

            // 비트 연산자
            // or, and, xor, not, shift-left, shift-right
            // 정수형 연산할 때 보통 씀
            // ====================================================

            int howManyBitYouWantToShift = 1;

            Console.WriteLine("비트연산 출력");
            Console.WriteLine(a | b);
            Console.WriteLine(a & b);
            Console.WriteLine(a ^ b);
            Console.WriteLine(~a);
            Console.WriteLine(a << howManyBitYouWantToShift);
            Console.WriteLine(a >> howManyBitYouWantToShift);
        }
    }
}
