using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _135_File_binaryFormatter
{
    /* 사용자 자료 입출력
     * [Serializable]
     * BinaryFormatter, Serialize, Deserialize 
     * 사용 빈도 높음, 직렬화.. 한줄로 나열한다..
     */ 
    [Serializable]
    struct Player
    {
        public string _Name;
        public int _Level;
        public double _Exp;
    }

    class Program
    {
        const string fileName = "savePlayer.txt";
        static void Main(string[] args)
        {
            Player[] player = new Player[2];

            player[0]._Name = "aaa";
            player[0]._Level = 10;
            player[0]._Exp = 5400;

            player[1]._Name = "bbb";
            player[1]._Level = 99;
            player[1]._Exp = 53470;

            // 쓰기
            FileStream fsW = new FileStream(fileName, FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fsW, player);
            fsW.Close();

            // 읽기
            FileStream fsR = new FileStream(fileName, FileMode.Open);

            BinaryFormatter bf2 = new BinaryFormatter();
            Player[] readPlayer = (Player[])bf2.Deserialize(fsR);

            for(int i = 0; i < readPlayer.Length; i++)
            {
                Console.WriteLine("Name: " + readPlayer[i]._Name);
                Console.WriteLine("Level: " + readPlayer[i]._Level);
                Console.WriteLine("Exp: " + readPlayer[i]._Exp);
            }

            fsR.Close();
        }
    }
}
