using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_Event
{
    
    public class TestClass
    {
        delegate void DelegateTest();
        int num = 100;
        double aa = 11.11;

        public void FuncTest()
        {
            Console.WriteLine("Hello");
        }

        public TestClass()
        {
            DelegateTest mydt;
            mydt = FuncTest;
            mydt();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
