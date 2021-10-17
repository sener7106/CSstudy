﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            Console.WriteLine("stack data: {0}", stack.Peek());

            while(stack.Count > 0)
            {
                Console.WriteLine("stack data {0}, count : {1}", stack.Pop(), stack.Count);
            }

            Console.WriteLine("\n 배열 데이터로 초기화");

            int[] arrData = { 100, 200, 300 };


        }

    }
}
