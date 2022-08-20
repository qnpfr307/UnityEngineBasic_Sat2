using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class OPs
    {
        public static int opCount;

        public static void Init()
        {
            Program.RegisterCallBack(Sum);
            Program.RegisterCallBack(Sub);
            Program.RegisterCallBack(Mul);
            Program.RegisterCallBack(Div);
            Program.RegisterCallBack(Mod);

            // 한정자 때문에 opDelegate 를 호출 할 수 없음.
        }

        public static int Sum(int a, int b)
        {
            Console.WriteLine($"OP: Sum(), result : {a + b}");
            opCount++;
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            Console.WriteLine($"OP: Sub(), result : {a - b}");
            opCount++;
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            Console.WriteLine($"OP: Mul(), result : {a * b}");
            opCount++;
            return a * b;
        }
        public static int Div(int a, int b)
        {
            if(b == 0)
            {
                Console.WriteLine("OP: Div(), result : 0으로 나눌 수 없습니다.");
                return 0;
            }
            Console.WriteLine($"OP: Div(), result : {a / b}");
            opCount++;
            return a / b;
        }
        public static int Mod(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("OP: Mod(), result : 0으로 나눌 수 없습니다.");
                return 0;
            }
            Console.WriteLine($"OP: Mod(), result : {a % b}");
            opCount++;
            return a % b;
        }
    }
}
