using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _007_Check
{
    /* 성적 프로그램을 3명까지만 저장하고 정보 검색이 가능한 프로글매
     * 배열을 사용한 데이터 저장
     * 저장했던 자료에서 학생번호로 정보 보여주기
     */
    class CStudent
    {
        private int id;
        private int kor;
        private int math;
        private int eng;

        public int ID {  get { return this.id; }   }
        public int KOR {  get { return this.kor; }   }
        public int MATH {  get { return this.math; }   }
        public int ENG {  get { return this.eng; }   }

        public CStudent()
        {
            this.id = 0;
            this.kor = 0;
            this.math = 0;
            this.eng = 0;
        }

        public void InputID()
        {
            Console.WriteLine("학생 ID를 입력하세요 ");
            this.id = int.Parse(Console.ReadLine());
        }

        public void InputKor()
        {
            Console.WriteLine("국어 성적을 입력하세요 : ");
            this.kor = int.Parse(Console.ReadLine());
        }
        public void InputMath()
        {
            Console.WriteLine("수학 성적을 입력하세요 : ");
            this.math = int.Parse(Console.ReadLine());
        }
        public void InputEng()
        {
            Console.WriteLine("영어 성적을 입력하세요 : ");
            this.eng = int.Parse(Console.ReadLine());
        }
        
        public void PrintID()
        {
            Console.WriteLine("학생 ID = [{0}]", this.id);

        }
        public int GetTotal()
        {
            return kor + eng + math;
        }

    }
    class Program
    {
        static void PrintID(Hashtable hashTable)
        {
            foreach(object key in hashTable.Keys)
            {
                CStudent castData = (CStudent)hashTable[key];
                castData.PrintID();
            }
        }

        static int CheckID(int id, Hashtable hashtable)
        {
            if (hashtable.ContainsKey(id))
                return id;

            return -1;
        }

        static void Main(string[] args)
        {
            int inputSel = 0;
            int selID = -1;

            Hashtable hashStudents = new Hashtable();

            while(true)
            {
                PrintID(hashStudents);
                Console.WriteLine("=== 성적 입력중 === (0) 나가기");
                if (Console.ReadLine() == "0")
                    break;

                CStudent temp = new CStudent();
                temp.InputID();
                temp.InputKor();
                temp.InputMath();
                temp.InputEng();

                hashStudents.Add(temp.ID, temp);
                Console.WriteLine();
            }

            Console.Clear();

            while(true)
            {
                PrintID(hashStudents);
                Console.WriteLine("학생 ID를 입력하세요? (0) 나가기 ");
                inputSel = int.Parse(Console.ReadLine());

                if (inputSel == 0)
                    break;

                selID = CheckID(inputSel, hashStudents);

                if(selID >= 0)
                {
                    CStudent selCStudent = (CStudent)hashStudents[selID];
                    Console.WriteLine();
                    Console.WriteLine("국어 점수 : {0}", selCStudent.KOR);
                    Console.WriteLine("수학 점수 : {0}", selCStudent.MATH);
                    Console.WriteLine("영어 점수 : {0}", selCStudent.ENG);

                    int total = selCStudent.GetTotal();
                    Console.WriteLine("총점:  {0}", total);
                    Console.WriteLine("평균:  {0}", total / hashStudents.Count);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("학생 아이디가 없어요. 다시 입력하세요");
                }
            }
        }
    }
}
