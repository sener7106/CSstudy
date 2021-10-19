using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_indexer_연습_
{
    class MyClass
    {
        private const int MAX = 10;
        private string name;

        private int[] data = new int[MAX];

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= MAX)
                    throw new IndexOutOfRangeException();
                else
                    return data[index];
            }
            set
            {
                if(!(index <0 || index>= MAX))
                {
                    data[index] = value;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass cls = new MyClass();

            // 인덱서 set 사용
            cls[1] = 1024;

            // 인덱서 get 사용
            int i = cls[1];
            Console.WriteLine(i);
        }
    }
}
