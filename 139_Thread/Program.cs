using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace _139_Thread
{
    /* 
     * 프로세스
     * 실행 중인 프로그램
     * 스케줄링 : 생성 > 준비 > 실행 > 대기 ... > 종료
     * 멀티태스킹
     * 
     * 
     * 스레드
     * OS가 CPU 시간을 할당하는 기본 단위
     * 하나 이상의 스레드로 구성
     */
    class Program
    {
        static void RunThread(int index)
        {
           // DateTime start = DateTime.Now;
            var sw = Stopwatch.StartNew();

            Console.WriteLine(string.Format("RunThread index : {0} Start", index));

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("RunThread index : {0} sec : {1:N2}", index, sw.ElapsedMilliseconds / 1000.0f);
                Thread.Sleep(100);
            }
        }

        static void RunThread()
        {
            var sw = Stopwatch.StartNew();

            Console.WriteLine(string.Format("RunThread index : 0 Start"));

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Run Thread index : {0} sec : {1:N2}", "0", sw.ElapsedMilliseconds / 1000.0f);
                Thread.Sleep(100);
            }

            Console.WriteLine(string.Format("RunThread index : 0 End"));
            Console.WriteLine();
            
        }

        static void RunThreadObject(object index)
        {
            var sw = Stopwatch.StartNew();
            Console.WriteLine(string.Format("RunThread index: {0} Start", index));

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("RunThreadObject index : {0}, sec: {1:N2}", index, sw.ElapsedMilliseconds / 1000.0f);
                Thread.Sleep(100);
            }

            Console.WriteLine(string.Format("RunThread index: {0} End", index));
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            RunThread();
            RunThread(1);
            RunThread(2);

            Thread _thread = new Thread(RunThread);
            _thread.Start();

            Console.WriteLine("============================");
            Console.WriteLine();

            Thread _thread2 = new Thread(() => RunThread(1));
            _thread2.Start();

            new Thread(() => RunThread(2)).Start();

            Thread thread2 = new Thread(new ParameterizedThreadStart(RunThreadObject));

            thread2.Start(3); // 매개 변수를 갖는 쓰레드 실행하는 방법 (object 매개변수만 넘길 수 있다)


            
        }
    }
}
