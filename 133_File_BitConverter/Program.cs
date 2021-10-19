using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _133_File_BitConverter
{
    /* FileStream, BitConverter
     * 데이터 형식을 byte 배열로 변환(BitConverter)
     * 사용 빈도 낮음
     */
   
    class Program
    {
        const string fileName = "a.txt";

        static void Main(string[] args)
        {
            // 파일 쓰기
            long lValue = 1234567890123456789;
            int num = 100;
            Console.WriteLine("lValue: " + lValue);
            Console.WriteLine("num : " + num);

            Stream outStream = new FileStream(fileName, FileMode.Create);
            byte[] wBytes = BitConverter.GetBytes(lValue);

            Console.Write("Byte : ");

            foreach (var item in wBytes)
                Console.Write("{0:X2} ", item);
            Console.WriteLine();

            outStream.Write(wBytes, 0, wBytes.Length);

            wBytes = BitConverter.GetBytes(num); // sizeof(int)

            Console.Write("Byte: ");

            foreach (var item in wBytes)
                Console.Write("{0:X2} ", item);
            Console.WriteLine();

            outStream.Write(wBytes, 0, wBytes.Length);
            outStream.Close();

            // 파일 읽기
            FileStream inStream = new FileStream(fileName, FileMode.Open);
            byte[] rBytes = new byte[sizeof(long)];
            inStream.Read(rBytes, 0, rBytes.Length);
            long readValue = BitConverter.ToInt64(rBytes, 0);

            rBytes = new byte[sizeof(int)];
            inStream.Read(rBytes, 0, rBytes.Length);
            int readNum = BitConverter.ToInt32(rBytes, 0);

            Console.WriteLine("Read Data : " + readValue);
            Console.WriteLine("Read Data : " + readNum);

            inStream.Close();
        }
    }
}
