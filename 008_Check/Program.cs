using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _008_Check
{
    class CSaveNumber
    {
        private int number1 { get; set; }
        private int number2 { get; set; }

        public CSaveNumber()
        {
            number1 = 0;
            number2 = 0;
        }

        public void InputNumber(int count)
        {
            if (count == 0) {
                Console.Write(" 첫번 째 수를 입력해주세요 ");
                number1 = int.Parse(Console.ReadLine());
             } else
            {
                Console.Write(" 두번 째 수를 입력해주세요 ");
                number2 = int.Parse(Console.ReadLine());
            }
         }

        public void PrintResult()
        {
            Console.WriteLine("계산 결과 : {0}", (number1 + number2));
        }
    }
    class Program
    {
        static bool CheckEnd(int index)
        {
            bool isEnd = false;
            int temp = 0;

            Console.WriteLine("{0}번째 추가로 계산할까요? (1: OK 0 : NO) ", (index + 1));
            temp = int.Parse(Console.ReadLine());
            isEnd = (temp == 0);

            return isEnd;
        }
        static void Main(string[] args)
        {
            ArrayList saveNumbers = new ArrayList(); // CSaveNumber[] saveNumbers = new CSaveNumber[10];

            while (true)
            {
                CSaveNumber temp = new CSaveNumber();
                temp.InputNumber(0);
                temp.InputNumber(1);

                temp.PrintResult();
                saveNumbers.Add(temp);

                if (CheckEnd(saveNumbers.Count))
                {
                    foreach(CSaveNumber data in saveNumbers)
                    {
                        data.PrintResult();
                    }
                    break;
                }

            }
        }
    }
}
