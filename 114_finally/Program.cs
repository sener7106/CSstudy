using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _114_finally
{
    class Program
    {
        static void ThrowFunc(int num)
        {
            if(num > 0)
            {
                Console.WriteLine("num data : " + num);
            }
            else
            {
                throw new Exception("data에 0이 입력되었습니다..");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                ThrowFunc(0);
                ThrowFunc(10);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }finally
            {
                Console.WriteLine(" finally 무조건 실행 ");
            }
        }
    }
}
