using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjcet
{
    class AA<T> where T : struct
    {
        private T sData;

        public AA()
        {
            sData = default(T);
        }
        public void Print()
        {
            Console.WriteLine("" + sData);
        }
    }
    
    class BB<T> where T : class
    {
        private T sRefData;

        public BB()
        {
            sRefData = default(T);
        }

        public void Print()
        {
            if (sRefData == null) Console.WriteLine("Null sRefData");
            else Console.WriteLine("sRefData: " + sRefData);
        }
    }

    interface II
    {
        void IIPrint();
    }

    class CC<T> where T: II
    {
        public T _interface;
    }

    class DD : II
    {
        public void IIPrint()
        {
            Console.WriteLine("DDbase : ");
        }
    }
    class Program
    {
        static T AddArray <T>(T[] arrDatas)
        {
            dynamic temp = default(T);
            for (int i = 0; i < arrDatas.Length; i++)
                temp += arrDatas[i];
            return temp;
        }

        static T SumArray <T>(T[] arrDatas)
        {
            T temp = default(T);
            for(int i =0; i< arrDatas.Length; i++)
            {
                temp += (dynamic)arrDatas[i];
            }
            return temp;
        }

        static void PrintArray<T>(T[] arrDatas)
        {
            foreach (var data in arrDatas)
                Console.WriteLine("data : {0}", data);
        }
       static void Main(String[] args)
        {
            int[] arrNums = { 1, 2, 3, 4, 5 };

            Console.WriteLine("AddArray : {0}", AddArray(arrNums));
            PrintArray(arrNums);
           
            
        }
    }
}
