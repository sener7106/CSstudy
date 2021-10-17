using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Exception
{
    // System.Exception, 예외 클래스의 Base
    // 피라미드 형식으로 아래로 예외처리를 해야함
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = 10;

            try
            {
                checked
                {
                    maxNum += Int32.MaxValue;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("e.Message : " + e.Message);
                Console.WriteLine("e.Source : " + e.Source);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("maxNum: " + maxNum);
        }
    }
}
