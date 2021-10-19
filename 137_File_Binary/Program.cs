using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _137_File_Binary
{
    /* 이진 입출력
     * BinaryWriter, BinaryReader
     * 모든 기본 데이터 형식에 읽고 쓰기 오버로딩
     */

    // using CCPS = CustomClassPlayerSpecial;
    // class CustomClassPlayerSpecial { public int num; }
    // using을 사용해서 class의 이름을 약어로 사용 가능함
    // Disposable의 인터페이스를 상속받은 클래스..
    // using문 사용 끝나면 자동으로 close됨.. why? interface에 이미 정의됨;
    
    class Program
    {
        static public string fileName = "data.dat";
        static public string fileName2 = "dataUsing.dat";


        static void Main(string[] args)
        {
            WriteData();
            ReadData();
        }

        static void WriteData()
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(100);
            bw.Write(100.001f);
            bw.Write("HelloWorld");
            bw.Write(true);

            bw.Close();
        }

        static void ReadData()
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            int num = br.ReadInt32();
            float fNum = br.ReadSingle();
            string str = br.ReadString();
            bool isData = br.ReadBoolean();

            Console.WriteLine("num : " + num);
            Console.WriteLine("fNum : " + fNum);
            Console.WriteLine("str : " + str);
            Console.WriteLine("isData : " + isData);

            br.Close();
        }
    }
}
