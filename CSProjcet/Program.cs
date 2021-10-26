using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


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

        static void Main(string[] args)
        {

            string s = "a234";
            string answer = "";
            char[] ch = s.ToCharArray();
            string[] num = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            
            
            List<int> listData = new List<int>();


            for (int i = 0; i < ch.Length; i++) {
                listData.Add((int)ch[i]);
            }

            listData.Sort((a, b) => { return b - a; });

            for(int i = 0; i < listData.Count; i ++)
            {
                answer += (char)listData[i];
                
            }

            Console.WriteLine(answer);

            foreach (var data in ch)
                Console.WriteLine(data);

    
            

        }
    }

    
 }


