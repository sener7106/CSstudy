using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _003_Stack
{
    /* Stack
     * 순차적 데이터 처리
     * LIFO
     * 뒤로 가기 기능 구현
     * Push(), Pop(), Peek()
     */

    class Program
    {
       static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            for (int i=0; i< 10; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine("stack data: {0}", stack.Peek());

            while(stack.Count > 0)
            {
                Console.WriteLine("queue data : {0} , count : {1}", stack.Pop(), stack.Count);
            }

            // 배열데이터로 초기화
            Console.WriteLine("배열데이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            Stack stackCopy = new Stack(arrData);

            foreach(object data in stackCopy)
            {
                Console.WriteLine("stackCopy data : " + data);
            }N
        }
    }
}


/*  static int LSearch(int[] ar, int len, int target)
        {
            
            for (int i = 0; i < len; i++)
            {
                if (ar[i] == target)
                    return i;
            }
                return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int idx;
            idx = LSearch(arr, arr.Length, 4);
            if (idx == -1)
                Console.WriteLine("탐색 실패");
            else
                Console.WriteLine("타겟 저장 인뎃스 " + idx);

            
        }
*/
