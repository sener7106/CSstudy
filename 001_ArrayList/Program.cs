using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _001_ArrayList
{
    /*
     * 컬렉션 
     * 데이터 저장, 검색, 데이터 처리에 특화
     * 자료구조 
     * 선언 방법, 참조 방법, 중요 메소드
     */
     // ArrayList,, 배열과 비슷 길이가 유동적
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            arrList.Add("Hello");
            arrList.Add("JACK");
            arrList.Add(10f);

            for (int i = 0; i< 10; i++)
            {
                arrList.Add(i);
            }

            foreach (object data in arrList)
            {
                Console.WriteLine("arrList data: " + data);
            }
            // 배열데이터로 초기화
            Console.WriteLine("배열 데이터로 초기화");
            int[] arrData = { 10, 20, 30 };
            ArrayList arrCopyList = new ArrayList(arrData);
            
            foreach (object data in arrCopyList)
            {
                Console.WriteLine("arrCopyList Data : " + data);
            }

        }
    }
}
