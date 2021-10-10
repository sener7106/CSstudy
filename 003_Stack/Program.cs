using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _003_Stack
{
    class Program
    {
        static int LSearch(int[] ar, int len, int target)
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
    }
}
