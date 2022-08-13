using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 박싱: 기존 자료형을 객체로 변환하는 과정
            // 언박성: 객체를 특정 자료형으로 변환하는 과정
            ArrayList arryList = new ArrayList();
            arryList.Add(1); // 명시적 형변환
            arryList.Add("dfdf"); // 암시적 형변환
            arryList.Add('o');

            for (int i = 0; i < arryList.Count; i++)
            {
                Console.WriteLine(arryList[i]);
            }

            Hashtable hashTable = new Hashtable();
            hashTable.Add("철수", 90);
            Console.WriteLine(hashTable["철수"]);

            List<int> list = new List<int>();
            List<string> stringList = new List<string>();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
            list.Add(1);
            list.Add(2);
            list.Remove(2);
            list.RemoveAt(0);
            list.Find(x => x == 1);
            list.FindIndex(x => x == 1);

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddFirst(2);

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("사과", "쌍떡잎식물 장미목 장미과 낙엽교목 식물인 사과나무의 열매로, 이과에 속하며 지름 5 ~ 10cm 정도의 둥근 모양으로 빛깔");
            Console.WriteLine(dictionary["사과"]);

            // Queue
            // FIFO: First Input, First Output System
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("철수");
            queue.Enqueue("영희");
            queue.Enqueue("지희");
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());

            // Stack
            // LIFO: Last Input, First Output System
            Stack<string> stack = new Stack<string>();
            stack.Push("철수");
            stack.Push("영희");
            stack.Push("지희");
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
        }


    }
}
