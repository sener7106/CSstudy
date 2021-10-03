﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _002_Queue
{
    /* Queue
     * 순차적 데이터의 처리
     * FIFO(First in First Out)
     * 게임에서 순차적 AI기능을 구현
     * Dequeue(), Enqueue(), Peek()
     */
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");

            for(int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            Console.WriteLine("queue data : {0}", queue.Peek());

            while(queue.Count > 0)
            {
                Console.WriteLine("queue data : {0}, count: {1}", queue.Dequeue(), queue.Count);
            }

            // 배열 데이터로 초기화
            Console.WriteLine(" \n 배열 데이터로 초기화.. ");

            int[] arrData = { 100, 200, 300 };

            Queue arrCopyQueue = new Queue(arrData);

            foreach(object data in arrCopyQueue)
            {
                Console.WriteLine("data : " + data);
            }
        }
    }
}
