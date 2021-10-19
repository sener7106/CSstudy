using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _132_File01
{
    /* Stream
     * 데이터를 바이트 단위로 읽고 사용, 파일, 네트워크 등에서 사용
     * File & Directory 클래스
     * 
     * System.IO
     * 파일과 데이터 스트림에 읽고 쓸 수 있게 하는 형식
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            string path = "";

            if(args.Length <= 0)
            {
                path = Directory.GetCurrentDirectory();
                path += "\\a.txt";

                Console.WriteLine("path: " + path);
            }
            else
            {
                path = args[0];
            }

            if(File.Exists(path)) {  // using System.IO

                Console.WriteLine("\nGetCreationtime: " + File.GetCreationTime(path));
            } else
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }

            FileInfo fileInfo = new FileInfo("b.txt");
            FileStream ff = fileInfo.Create();

            ff.Close();
        }
    }
}
