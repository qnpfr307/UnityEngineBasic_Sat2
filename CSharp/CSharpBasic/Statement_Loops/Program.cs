﻿using System;

namespace Statement_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tmpArr = { 1, 2, 3, 4, 5 };

            int count = 0;

            // while
            while(count < tmpArr.Length)
            {
                // break 상위 반복문을 빠져나오는 분기문
                // continue 상위 반복문의 조건 비교문으로 돌아가는 분기문
                // return 해당 함수를 종료하고 결과를 반환

                if (count == 3)
                {
                    count++;
                    continue;
                }

                Console.WriteLine(tmpArr[count]);
                count++;
            }

            count = 0;

            do
            {
                Console.WriteLine(tmpArr[count]);
                count++;
            } while(count < tmpArr.Length);

            // for (인덱스용 변수 초기화; 반복 조건문; 루프 한 번 실행 후 수행할 연산)
            for (count = 0; count < tmpArr.Length; count++)
            {
                Console.WriteLine(tmpArr[count]);
            }

            int[,] mat2D = new int[3, 5]
            {
                { 1, 2, 3, 4, 5},
                { 4, 5, 6, 7, 8},
                { 5, 6, 7, 8, 4}
            };

            for (int i = 0; i < mat2D.GetLength(0); i++)
            {
                for (int j = 0; j < mat2D.GetLength(1); j++)
                {
                    Console.Write(mat2D[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
