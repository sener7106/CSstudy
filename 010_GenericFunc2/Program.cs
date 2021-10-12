using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_GenericFunc2
{
    class GenericAA<T>
    {
        private T num;
        public T GetNum()
        {
            return num;
        }

        public void SetNum(T data)
        {
            num = data;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericAA<int> AA = new GenericAA<int>();
            AA.SetNum(100);
            Console.WriteLine("AA: " + AA.GetNum());
        }
    }
}
