using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_GenericFunc
{
    /* 일반화(Generic)
     * 클래수, 함수를 일반화 기능
     * <T> 키워드
     * 장점: boxing, unboxing을 줄일 수 있음
     * 불필요한 오버로딩을 줄일수 있음.
     */

    class Program
    {
        static void GenericPrint <T>(T data)
        {
            Console.WriteLine("data {0}", data);
        }
        
        static void GenericPrint <T>(T[] arrData)
        {
            for(int i = 0; i< arrData.Length; i++)
            {
                Console.WriteLine("arrData : {0}", arrData[i]);
            }
        }
        static void Main(string[] args)
        {
            int a = 10;
            float b = 10.3f;
            string c = "hello";

            int[] arrA = { 1, 2, 3 };
            string[] arrB = { "A", "B", "C", "D" };
            GenericPrint(a);
            GenericPrint(b);
            GenericPrint(c);

            Console.WriteLine();
            GenericPrint(arrA);
            Console.WriteLine();
            GenericPrint(arrB);
        }
    }
}
