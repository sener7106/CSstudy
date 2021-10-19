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
        private int eng;
        private int math;

        public int ID { get { return this.id; } }
        public int KOR { get { return this.kor; } }
        public int ENG { get { return this.eng; } }
        public int MATH { get { return this.math; } }

        public CStudent()
        {
            this.id = 0;
            this.kor = 0;
            this.math = 0;
            this.eng = 0;
        }

        public int InputID()
        {
            Console.Write("학생 ID를 입력해주세요.. ");
            return this.id = int.Parse(Console.ReadLine());
        }

        public int InputKOR()
        {
            Console.Write("국어 성적을 입력해주세요.. ");
            return this.kor = int.Parse(Console.ReadLine());
        }

        public int InputENG()
        {
            Console.Write("영어 성적을 입력해주세요.. ");
            return this.eng = int.Parse(Console.ReadLine());
        }

        public int InputMATH()
        {
            Console.Write("수학 성적을 입력해주세요.. ");
            return this.math = int.Parse(Console.ReadLine());
        }

        public void PrintID()
        {
            Console.WriteLine(" 학생 ID [{0}] ", this.id);
        }

    }

    class Program
    {
        static void PrintID(Hashtable hashtable)
        {
            foreach (int key in hashtable.Keys)
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
            int inputSel;
            int selID;

            Hashtable hashStudents = new Hashtable();

            while(true)
            {
                PrintID(hashStudents);
                Console.WriteLine(" == 성적 입력 == (0 입력시 종료) ");
                if (Console.ReadLine() == "0")
                    break;

                CStudent temp = new CStudent();
                temp.InputID();
                temp.InputKOR();
                temp.InputENG();
                temp.InputMATH();

                hashStudents.Add(temp.ID, temp);

            }

            while(true)
            {
                
                PrintID(hashStudents);
                Console.WriteLine("학생 ID를 입력해주세요.. (0 입력 시 종료)");
                inputSel = int.Parse(Console.ReadLine());
                if(inputSel == 0)
                {
                    break;
                } else
                {
                    selID = CheckID(inputSel, hashStudents);
                }

                if(selID >= 0)
                {

                    CStudent selStudent = (CStudent)hashStudents[selID];

                    Console.WriteLine(" 학생 ID : " + selStudent.ID);
                    Console.WriteLine(" 국어 성적 : " +selStudent.KOR);
                    Console.WriteLine(" 영어 성적 : " + selStudent.ENG);
                    Console.WriteLine(" 수학 성적 : " + selStudent.MATH);
                }
                else
                {
                    Console.WriteLine("\n 입력하신 학생 아이디가 존재하지 않습니다. ");
                }
            }
        }
    }
}