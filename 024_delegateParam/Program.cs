using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_delegateParam
{
    /* delegate함수로 파라미터로 만든다면, 확장성이 용이하다..
     * 참조형 메서드를 추가, 함수의 재사용
     */
    delegate void delegateFunc();

    class MessageProcess
    {
        delegateFunc CallOkFunc;
        delegateFunc CallCancelFunc;

        public void Message(string msg, delegateFunc okFunc, delegateFunc cancelFunc)
        {
            CallOkFunc = okFunc;
            CallCancelFunc = cancelFunc;

            Console.WriteLine("Message: " + msg + " (0: OK, 1: cancel)");

            string inputStr = Console.ReadLine();

            if(inputStr.Equals("0"))
            {
                CallOkFunc();
            }
            else
            {
                CallCancelFunc();
            }
        }
    }

    class Program
    {
        static void CallOK()
        {
            Console.WriteLine("CallOK");
        }
        static void CallCancel()
        {
            Console.WriteLine("CallCancel");
        }
        static void Main(string[] args)
        {
            MessageProcess msg = new MessageProcess();
            msg.Message("TestMessage", CallOK, CallCancel);

        }
    }
}
