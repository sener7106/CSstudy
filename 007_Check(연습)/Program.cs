using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _007_Check_연습_
{
    class CStudent
    {
        private int id;
        private int kor;
        private int math;
        private int eng;

        public int ID { get { return this.id; } }
        public int KOR { get { return this.kor; } }
        public int MATH { get { return this.math; } }
        public int ENG { get { return this.eng; } }
    
        public CStudent()
        {
            this.id = 0;
            this.kor = 0;
            this.math = 0;
            this.eng = 0;
        }

        public void InputID()
        {
            Console.Write("학생 ID를 입력해주세요 : ");
            this.id = int.Parse(Console.ReadLine());
        }

        public void InputKor()
        {
            Console.Write("국어 성적을 입력해주세요 : ");
            this.id = int.Parse(Console.ReadLine());
        }

        public void InputMath()
        {
            Console.Write("수학 성적을 입력해주세요 : ");
            this.id = int.Parse(Console.ReadLine());
        }
        public void InputEng()
        {
            Console.Write("영어 성적을 입력해주세요 : ");
            this.id = int.Parse(Console.ReadLine());
        }

        public void PrintID()
        {
            Console.WriteLine("학생 ID : {0}", this.id);
        }
    }
    class Program
    {
        static void PrintID(Hashtable hashtable)
        {
            foreach(object key in hashtable.Keys)
            {
                CStudent castdata = (CStudent)hashtable[key];
                castdata.PrintID();
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

                Console.WriteLine(" == 성적 입력중 == (0) 나가기");
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

            while(true)
            {
                PrintID(hashStudents);

                Console.WriteLine(" 학생 ID를 입력해주세요.. (0) 나가기 ");
                inputSel = int.Parse(Console.ReadLine());

                if (inputSel == 0)
                    break;
         

                selID = CheckID(inputSel, hashStudents);

                if(selID >= 0)
                {
                    CStudent selStudent = (CStudent)hashStudents[selID];
                    
                }


            }
        }
        
    }
}
